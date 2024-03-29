﻿using System;
using System.Collections.Generic;

namespace _165.ConcatenatedWords
{
    class Program
    {
        public class TrieNode
        {
            public TrieNode[] Children = new TrieNode[26];
            public bool IsWord;

            public static void Insert(TrieNode root, string word)
            {
                TrieNode node = root;
                foreach (char c in word)
                {
                    int index = c - 'a';
                    if (node.Children[index] == null)
                    {
                        node.Children[index] = new TrieNode();
                    }

                    node = node.Children[index];
                }

                node.IsWord = true;
            }


            public static bool Search(TrieNode root, Dictionary<int, bool> cache, string word, int start, int concatCount)
            {
                TrieNode node = root;
                if (cache.ContainsKey(start))
                {
                    // Console.WriteLine("Found in cache: " + start);
                    return cache[start];
                }

                for (int i = start; i < word.Length; i++)
                {
                    int index = word[i] - 'a';
                    if (node.Children[index] == null)
                    {
                        cache[start] = false;
                        return false;
                    }

                    node = node.Children[index];
                    if (node.IsWord)
                    {
                        if (i == word.Length - 1)
                        {
                            cache[start] = concatCount >= 1;
                            return concatCount >= 1;
                        }

                        if (Search(root, cache, word, i + 1, concatCount + 1))
                        {
                            cache[start] = true;
                            return true;
                        }
                    }
                }

                cache[start] = false;
                return false;
            }

        }

        public IList<string> FindAllConcatenatedWordsInADict(string[] words)
        {
            IList<string> result = new List<string>();
            TrieNode root = new TrieNode();

            foreach (var word in words)
            {
                TrieNode.Insert(root, word);
            }

            foreach (var word in words)
            {
                if (TrieNode.Search(root, new Dictionary<int, bool>(), word, start: 0, concatCount: 0))
                {
                    result.Add(word);
                }
            }

            return result;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            string[] words = { "cat", "cats", "catsdogcats", "dog", "dogcatsdog", "hippopotamuses", "rat", "ratcatdogcat" };
            IList<string> result = p.FindAllConcatenatedWordsInADict(words);
            Console.WriteLine(result.Count);
        }
    }
}
