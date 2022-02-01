using System;

namespace _166.PrefixSuffixWord
{
    class Program
    {
        public class WordFilter
        {
            public class TrieNode
            {
                public TrieNode[] Children = new TrieNode[27];
                public int Weight;

                public static void Insert(TrieNode root, string word, int weight)
                {
                    string wrapped = word + "{" + word; // { - 'a' = 27

                    int end = 2 * word.Length + 1;
                    for (int i = 0; i <= word.Length; i++)
                    {
                        insert(root, wrapped, i, end, weight);
                    }
                }

                private static void insert(TrieNode root, string word, int start, int end, int weight)
                {
                    TrieNode node = root;
                    for (int i = start; i < end; i++)
                    {
                        int index = word[i] - 'a';
                        if (node.Children[index] == null)
                        {
                            node.Children[index] = new TrieNode();
                        }

                        node = node.Children[index];
                        node.Weight = weight;
                    }
                }

                public static int Search(TrieNode root, string word)
                {
                    TrieNode node = root;
                    foreach (char c in word)
                    {
                        int index = c - 'a';
                        if (node.Children[index] == null)
                        {
                            return -1;
                        }

                        node = node.Children[index];
                    }

                    return node.Weight;
                }

            }


            TrieNode root;

            public WordFilter(string[] words)
            {
                root = new TrieNode();

                for (int i = 0; i < words.Length; i++)
                {
                    TrieNode.Insert(root, words[i], i);
                }
            }

            public int F(string prefix, string suffix)
            {
                TrieNode node = root;
                string searchWord = suffix + "{" + prefix;

                int weight = TrieNode.Search(node, searchWord);
                return weight;
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            string[] word = { "apple" };
            WordFilter wordFilter = new WordFilter(word);
           int result =  wordFilter.F("a","e");
            Console.WriteLine(result);
        }
    }
}
