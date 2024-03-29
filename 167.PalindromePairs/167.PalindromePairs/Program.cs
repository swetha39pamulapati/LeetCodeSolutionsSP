﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _167.PalindromePairs
{
    class Program
    {
        class TrieNode
        {
            public char ch;
            public int index;
            public Dictionary<char, TrieNode> children;

            public TrieNode(char ch = '~')
            {
                this.ch = ch;
                children = new Dictionary<char, TrieNode>();
                index = -1;
            }

            public static TrieNode GenerateTrie(string[] words)
            {
                var root = new TrieNode();
                var i = 0;
                foreach (var word in words)
                {
                    var node = root;
                    foreach (var ch in word)
                    {
                        if (!node.children.ContainsKey(ch)) node.children[ch] = new TrieNode(ch);
                        node = node.children[ch];
                    }
                    node.index = i;
                    i++;
                }
                return root;
            }
        }
        public IList<IList<int>> PalindromePairs(string[] words)
        {
            var res = new List<IList<int>>();
            if (words.Length == 0)
            {
                res.Add(new List<int>());
                return res;
            }
            var trie = TrieNode.GenerateTrie(words);
            var i = 0;
            foreach (var word in words)
            {
                if (word == "")
                {
                    // handle the idiotic empty string case
                    for (int e = 0; e < words.Length; e++)
                    {
                        if (i != e && isPalindrome(words[e], words[e].Length - 1))
                        {
                            res.Add(new List<int>(new[] { e, i }));
                            res.Add(new List<int>(new[] { i, e }));
                        }
                    }
                }

                var node = trie;
                for (int c = word.Length - 1; c >= 0; c--)
                {
                    var ch = word[c];
                    if (!node.children.ContainsKey(ch)) break;
                    node = node.children[ch];
                    if (node.index != i && c == 0 && node.index > -1)
                    {
                        // both trie word and this word are same length
                        res.Add(new List<int>(new[] { node.index, i }));
                    }
                    else if (node.index != i && node.index > -1 && c > 0)
                    {
                        //the trie stuff finished earlier, check if the remainder of word is a palindrome
                        if (isPalindrome(word, c - 1))
                        {
                            res.Add(new List<int>(new[] { node.index, i }));
                        }
                    }

                    if (c == 0)
                    {
                        //word finished, check if the remainder of the trie words are palndromes

                        foreach (var child in node.children.Values)
                        {
                            var trieSuffixes = new List<(int, string)>();
                            findTrieSuffixes(child, trieSuffixes, new StringBuilder());
                            foreach (var suffix in trieSuffixes)
                            {
                                if (suffix.Item1 != i && isPalindrome(suffix.Item2, suffix.Item2.Length - 1))
                                {
                                    res.Add(new List<int>(new[] { suffix.Item1, i }));
                                }
                            }
                        }
                    }
                }
                i++;
            }
            return res;
        }

        private static bool isPalindrome(string s, int c)
        {
            var l = 0;
            while (l <= c)
            {
                if (s[l] != s[c]) return false;
                l++;
                c--;
            }
            return true;
        }

        private static void findTrieSuffixes(TrieNode node, List<(int, string)> trieSuffixes, StringBuilder sb)
        {
            sb.Append(node.ch);
            if (node.index > -1)
            {
                trieSuffixes.Add((node.index, sb.ToString()));
            }

            foreach (var child in node.children.Values)
            {
                findTrieSuffixes(child, trieSuffixes, sb);
            }
            sb.Remove(sb.Length - 1, 1);
        }

       
        static void Main(string[] args)
        {
            string[] words = { "abcd", "dcba", "lls", "s", "sssll" };
            Program p = new Program();
            IList<IList<int>> result = p.PalindromePairs(words);
            Console.WriteLine(result.Count);
        }
    }
}
