using System;
using System.Collections.Generic;

namespace _161.WordSearchii
{
    class Program
    {
        public class TrieNode
        {
            public char c;
            public string word;
            public TrieNode[] Children;
            public TrieNode(char c)
            {
                this.c = c;
                this.word = "";
                Children = new TrieNode[26];
            }
        }

        public IList<string> FindWords(char[][] board, string[] words)
        {

            List<string> res = new List<string>();

            if (board == null || board[0].Length == 0)
                return res;

            TrieNode root = new TrieNode('#');
            BuildTrieTree(root, words);

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    if (root.Children[board[i][j] - 'a'] != null)
                        DFS(board, root, i, j, res);
                }
            }

            return res;
        }

        private void DFS(char[][] board, TrieNode curr, int i, int j, List<string> res)
        {
            if (i < 0 || i >= board.Length || j < 0 || j >= board[0].Length)
                return;

            char c = board[i][j];
            if (c == '#' || curr.Children[c - 'a'] == null)
                return;
            curr = curr.Children[c - 'a'];
            if (curr.word != "")
            {
                res.Add(curr.word);
                curr.word = "";
            }

            board[i][j] = '#';
            DFS(board, curr, i - 1, j, res);
            DFS(board, curr, i + 1, j, res);
            DFS(board, curr, i, j - 1, res);
            DFS(board, curr, i, j + 1, res);
            board[i][j] = c;
        }

        private void BuildTrieTree(TrieNode root, string[] words)
        {
            foreach (string word in words)
            {
                TrieNode curr = root;
                foreach (char c in word)
                {
                    if (curr.Children[c - 'a'] == null)
                        curr.Children[c - 'a'] = new TrieNode(c);
                    curr = curr.Children[c - 'a'];
                }
                curr.word = word;
            }
        }
        static void Main(string[] args)
        {
            char[][] matrix = new char[4][]
           {
                new char[]{ 'o','a','a','n'},
                 new char[]{ 'e', 't', 'a', 'e' },
                  new char[]{ 'i', 'h', 'k', 'r'},
                  new char[]{ 'i', 'f', 'l', 'v'},


           };
            Program p = new Program();
            string[] words = { "oath", "pea", "eat", "rain" };
            IList<string> result =  p.FindWords(matrix, words);
            Console.WriteLine(result.Count);
        }
    }
}
