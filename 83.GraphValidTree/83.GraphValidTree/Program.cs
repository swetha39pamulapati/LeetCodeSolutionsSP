using System;
using System.Collections.Generic;

namespace _83.GraphValidTree
{
    class Graph
    {
        private int V; // No. of vertices
        public int E;
        private List<int>[] adj; // Adjacency List

        // Constructor
        Graph(int v)
        {
            V = v;
            E = 0;
            adj = new List<int>[v];
            for (int i = 0; i < v; ++i)
                adj[i] = new List<int>();
        }

        // Function to add an edge
        // into the graph
        void addEdge(int v, int w)
        {
            E++;
            adj[v].Add(w);
            adj[w].Add(v);
        }

        // A recursive function that uses visited[]
        // and parent to detect cycle in subgraph
        // reachable from vertex v.
        void dfsTraversal(int v, bool[] visited)
        {
            visited[v] = true;

            // Recur for all the vertices adjacent to this
            // vertex
            List<int> list = adj[v];
            foreach (int i in list)
            {
                // If an adjacent is not visited, then recur for
                // that adjacent
                if (!visited[i])
                {
                    dfsTraversal(i, visited);
                }
            }
        }
        public bool isConnected()
        {
            // Mark all the vertices as not visited and not part
            // of recursion stack
            bool[] visited = new bool[V];
            for (int i = 0; i < V; i++)
                visited[i] = false;

            // Performing DFS traversal of the graph and marking
            // reachable vertices from 0 to true
            dfsTraversal(0, visited);

            // If we find a vertex which is not reachable from 0
            // (not marked by dfsTraversal(), then we return
            // false since graph is not connected
            for (int u = 0; u < V; u++)
                if (!visited[u])
                    return false;

            // since all nodes were reachable so we returned
            // true and and hence graph is connected
            return true;
        }

        // Returns true if the graph
        // is a tree, else false.
        bool isTree()
        {
            return isConnected() && E == V - 1;
        }

        // Driver Code
        public static void Main(String[] args)
        {
            // Create a graph given
            // in the above diagram
            Graph g1 = new Graph(5);
            g1.addEdge(0, 1);
            g1.addEdge(0, 2);
            g1.addEdge(0, 3);
            g1.addEdge(1, 4);
            if (g1.isTree())
                Console.WriteLine("Graph is Tree");
            else
                Console.WriteLine("Graph is not Tree");

            Graph g2 = new Graph(5);
            g2.addEdge(0,1);
            g2.addEdge(1, 2);
            g2.addEdge(2, 3);
            g2.addEdge(1, 3);
            g2.addEdge(1, 4);

            if (g2.isTree())
                Console.WriteLine(" G2 Graph is Tree");
            else
                Console.WriteLine("G2 Graph is not Tree");

        }
    }

}
