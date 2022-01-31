using System;

namespace _140.LongestWordInDictionary
{
    class Trie
    {
        class TrieNode
        {
            public string word;
            public TrieNode[] children = new TrieNode[26];

            public TrieNode()
            {
                word = "";
                for (int i = 0; i < 26; i++)
                    children[i] = null;
            }
            public void Insert(string s)
            {
                var charArray = s.ToCharArray();
                var iterate = this;

                for (int i = 0; i < charArray.Length; i++)
                {
                    int index = charArray[i] - 'a';

                    if (iterate.children[index] == null)
                    {
                        iterate.children[index] = new TrieNode();
                    }

                    // iteratet to next, move forward in the trie
                    iterate = iterate.children[index];
                }

                iterate.word = s;
            }

        }
        public string LongestWord(string[] words)
        {
            var root = new TrieNode();
            root.word = "-";

            foreach (string word in words)
            {
                root.Insert(word);
            }

            return findLongestWordThroughTrie(root, "");
        }
        private static string findLongestWordThroughTrie(TrieNode node, string accum)
        {
            if (node == null || node.word == null || node.word.Length == 0)
            {
                return accum;
            }

            // longest one, and also same length lexicographic smallest one
            string optimal = "";

            if (node.word.CompareTo("-") != 0)
            {
                accum = node.word;
            }

            foreach (var child in node.children)
            {
                var current = findLongestWordThroughTrie(child, accum);

                // longer                                  same length                      smaller in lexicographic order
                if (current.Length > optimal.Length || (current.Length == optimal.Length && current.CompareTo(optimal) < 0))
                {
                    optimal = current;
                }
            }

            return optimal;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
