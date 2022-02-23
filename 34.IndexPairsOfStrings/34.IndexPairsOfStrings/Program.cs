using System;
using System.Collections.Generic;

namespace _34.IndexPairsOfStrings
{
    //Given a text string and words (a list of strings), return all index pairs [i, j] so that the substring text[i]...text[j] is in the list of words.

//Input: text = "ababa", words = ["aba","ab"]
//Output: [[0,1],[0,2],[2,3],[2,4]]
//Explanation: 
//Notice that matches can overlap, see "aba" is found in [0,2] and[2, 4].
    class Trie
    {
        class TrieNode
        {
            public bool isEnd;
            public TrieNode[] children = new TrieNode[26];

            public TrieNode()
            {
                isEnd = false;
                for (int i = 0; i < 26; i++)
                    children[i] = null;
            }
        }
        private TrieNode root;

        public Trie()
        {
            root = new TrieNode();
        }
        public int[][] indexPairs(string text, string[] words)
        {
            /*initializing tire and put all word from words into Trie.*/
            foreach (string s in words)
            {
                TrieNode cur = root;
                foreach (char c in s)
                {
                    if (cur.children[c - 'a'] == null)
                    {
                        cur.children[c - 'a'] = new TrieNode();
                    }
                    cur = cur.children[c - 'a'];
                }
                cur.isEnd = true;       /*mark there is a word*/
            }

            /*if text is "ababa", check "ababa","baba","aba","ba","a" individually.*/
            int len = text.Length;
            List<int[]> list = new List<int[]>();
            for (int l = 0; l < len; l++)
            {
                TrieNode cur = root;
                char cc = text[l];
                int j = l;   /*j is our moving index*/

                while (cur.children[cc - 'a'] != null)
                {
                    cur = cur.children[cc - 'a'];
                    if (cur.isEnd)
                    {   /*there is a word ending here, put into our list*/
                        list.Add(new int[] { l, j });
                    }
                    j++;
                    if (j == len)
                    {  /*reach the end of the text, we stop*/
                        break;
                    }
                    else
                    {
                        cc = text[j];
                    }
                }
            }
            /*put all the pairs from list into array*/
            int size = list.Count;
            int[][] res = new int[size][];
            int i = 0;
            foreach (int[] r in list)
            {
                res[i] = r;
                i++;
            }
            return res;
        }
        static void Main(string[] args)
        {
            Trie trie = new Trie();
            string[] words = {  "aba" ,"ab"};
            int[][] result = trie.indexPairs("ababa", words);
            
            foreach (int[] data in result)
            {
                Console.Write("[");
                for (int i = 0; i<data.Length; i++)
                Console.Write(data[i] + " ");
                Console.Write("]");
            }
        }
    }
}

