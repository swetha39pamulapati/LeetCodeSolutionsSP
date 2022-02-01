using System;
using System.Collections.Generic;
using System.Text;

namespace _169.WordSquares
{
    class Program
    {
		internal class TrieNode
		{
			internal TrieNode[] children;
			internal bool isWord;

			internal TrieNode()
			{
				children = new TrieNode[26];
			}
		}

		public virtual IList<IList<string>> wordSquares(string[] words)
		{
			TrieNode root = buildTrie(words);
			IList<IList<string>> squares = new List<IList<string>>();

			foreach (string word in words)
			{
				IList<string> square = new List<string>();
				square.Add(word);
				wordSquares(root, word.Length, square, squares);
			}
			return squares;
		}

		private TrieNode buildTrie(string[] words)
		{
			TrieNode root = new TrieNode();
			foreach (string word in words)
			{
				TrieNode current = root;
				foreach (char c in word.ToCharArray())
				{
					int index = c - 'a';
					if (current.children[index] == null)
					{
						current.children[index] = new TrieNode();
					}
					current = current.children[index];
				}
				current.isWord = true;
			}
			return root;
		}

		private TrieNode search(TrieNode root, string prefix)
		{
			TrieNode current = root;
			foreach (char c in prefix.ToCharArray())
			{
				int index = c - 'a';
				if (current.children[index] == null)
				{
					return null;
				}
				current = current.children[index];
			}
			return current;
		}

		private void wordSquares(TrieNode root, int len, IList<string> square, IList<IList<string>> squares)
		{
			if (square.Count == len)
			{
				squares.Add(new List<string>(square));
				return;
			}

			string prefix = getPrefix(square, square.Count);
			TrieNode node = search(root, prefix);
			if (node == null)
			{
				return;
			}

			IList<string> children = new List<string>();
			getChildren(node, prefix, children);
			foreach (string child in children)
			{
				square.Add(child);
				wordSquares(root, len, square, squares);
				square.RemoveAt(square.Count - 1);
			}
		}

		private string getPrefix(IList<string> square, int index)
		{
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < index; i++)
			{
				sb.Append(square[i][index]);
			}
			return sb.ToString();
		}

		private void getChildren(TrieNode node, string s, IList<string> children)
		{
			if (node.isWord)
			{
				children.Add(s);
				return;
			}

			for (int i = 0; i < 26; i++)
			{
				if (node.children[i] != null)
				{
					getChildren(node.children[i], s + (char)('a' + i), children);
				}
			}
		}

		static void Main(string[] args)
        {
			Program p = new Program();
			string[] words = { "area", "lead", "wall", "lady", "ball" };
			IList<IList<string>> result = p.wordSquares(words);

			Console.WriteLine(result.Count);
        }
    }
}
