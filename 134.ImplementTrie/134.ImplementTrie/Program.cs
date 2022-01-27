using System;

namespace _134.ImplementTrie
{
    
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
        public void InsertNode(string word)
        {
            TrieNode cur = root;
            for(int i =0;i<word.Length; i++)
            {
                int id = word[i] - 'a';
                if (cur.children[id] == null)
                {
                    cur.children[id] = new TrieNode();
                }
                cur = cur.children[id];
            }
            cur.isEnd = true;
        }
        public bool search(string word)
        {
            TrieNode temp = root;
            foreach (var t in word)
            {
                var charIndex = t - 'a';
                if (temp.children[charIndex] == null)
                    return false;

                temp = temp.children[charIndex];
            }

            if (temp == null)
                return false;

            return temp.isEnd;

        }
        public bool StartsWith(string key)
        {
            TrieNode temp = root;
            foreach (var t in key)
            {
                var charIndex = t - 'a';
                if (temp.children[charIndex] == null)
                    return false;

                temp = temp.children[charIndex];
            }

            if (temp == null)
                return false;
            return true;
        }
        static void Main(string[] args)
        {
            Trie trie = new Trie();
            trie.InsertNode("apple");
            Console.WriteLine(trie.search("apple"));
            Console.WriteLine(trie.search("app"));
            Console.WriteLine(trie.StartsWith("app"));
            trie.InsertNode("app");
            Console.WriteLine(trie.search("app"));
        }
    }
}
