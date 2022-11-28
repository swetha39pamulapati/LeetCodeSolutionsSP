using System;
using System.Collections.Generic;
using System.Linq;

namespace _80.CloneGraph
{
    class Program
    {
        public class Node
        {
            public int val;
            public IList<Node> neighbors;

            public Node()
            {
                val = 0;
                neighbors = new List<Node>();
            }

            public Node(int _val)
            {
                val = _val;
                neighbors = new List<Node>();
            }

            public Node(int _val, List<Node> _neighbors)
            {
                val = _val;
                neighbors = _neighbors;
            }
        }
        public Node buildGraph()
        {
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            List<Node> v = new List<Node>();
            v.Add(node2);
            v.Add(node4);
            node1.neighbors = v;
            v = new List<Node>();
            v.Add(node1);
            v.Add(node3);
            node2.neighbors = v;
            v = new List<Node>();
            v.Add(node2);
            v.Add(node4);
            node3.neighbors = v;
            v = new List<Node>();
            v.Add(node3);
            v.Add(node1);
            node4.neighbors = v;
            return node1;
        }
            public Node CloneGraph(Node node)
        {

            if (node == null) return null;

            var oldAndNewNode = new Dictionary<Node, Node>();
            var isVisited = new HashSet<Node>();

            var queue = new Queue<Node>();
            queue.Enqueue(node);

            while (queue.Any())
            {
                var size = queue.Count;
                for (int s = 0; s < size; s++)
                {
                    var cur = queue.Dequeue();

                    if (isVisited.Contains(cur)) continue;
                    isVisited.Add(cur);
                    if (!oldAndNewNode.ContainsKey(cur))
                    {
                        oldAndNewNode[cur] = new Node(cur.val, new List<Node>()); ;
                    }
                    var curNew = oldAndNewNode[cur];
                    foreach (var next in cur.neighbors)
                    {
                        if (!oldAndNewNode.ContainsKey(next))
                        {
                            oldAndNewNode[next] = new Node(next.val, new List<Node>());
                        }
                        var nextNew = oldAndNewNode[next];
                        curNew.neighbors.Add(nextNew);
                        queue.Enqueue(next);
                    }
                }
            }
            return oldAndNewNode[node];

        }
        static void Main(string[] args)
        {
            Program p = new Program();
           
            Node source = p.buildGraph();
            Console.WriteLine("BFS traversal of a graph before cloning");
            Node data = p.CloneGraph(source);
            Console.WriteLine(data);
             Node newSource = p.CloneGraph(source);
            Console.WriteLine("BFS traversal of a graph after cloning");
            Node data1 = p.CloneGraph(newSource);
            Console.WriteLine(data1);
        }
    }
}
