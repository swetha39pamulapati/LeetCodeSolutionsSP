using System;
using System.Collections.Generic;
using System.Text;

namespace _158.AlienDictionary
{
	//https://www.youtube.com/watch?v=LA0X_N-dEsg
    class Program
    {
		public virtual string alienOrder(string[] words)
		{
			IDictionary<char, ISet<char>> graph = new Dictionary<char, ISet<char>>();
			int[] inDegree = new int[26];
			buildGraph(words, graph, inDegree);

			string order = topologicalSort(graph, inDegree);
			return order.Length == graph.Count ? order : "";
		}

		private void buildGraph(string[] words, IDictionary<char, ISet<char>> graph, int[] inDegree)
		{
			foreach (string word in words)
			{
				foreach (char c in word.ToCharArray())
				{
					graph[c] = new HashSet<char>();
				}
			}

			for (int i = 1; i < words.Length; i++)
			{
				string first = words[i - 1];
				string second = words[i];
				int length = Math.Min(first.Length, second.Length);

				for (int j = 0; j < length; j++)
				{
					char parent = first[j];
					char child = second[j];
					if (parent != child)
					{
						if (!graph[parent].Contains(child))
						{
							graph[parent].Add(child);
							inDegree[child - 'a']++;
						}
						break;
					}
				}
			}
		}

		private string topologicalSort(IDictionary<char, ISet<char>> graph, int[] inDegree)
		{
			LinkedList<char> queue = new LinkedList<char>();
			foreach (char c in graph.Keys)
			{
				if (inDegree[c - 'a'] == 0)
				{
					queue.AddLast(c);
				}
			}

			StringBuilder sb = new StringBuilder();
			while (queue.Count > 0)
			{
				char c = queue.RemoveFirst();
				sb.Append(c);
				foreach (char neighbor in graph[c])
				{
					inDegree[neighbor - 'a']--;
					if (inDegree[neighbor - 'a'] == 0)
					{
						queue.AddLast(neighbor);
					}
				}
			}
			return sb.ToString();
		}
	





	static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
