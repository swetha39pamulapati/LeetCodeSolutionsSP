using System;
using System.Collections.Generic;

namespace _83.GraphValidTree
{
    class Graph
    {
        private int V; // No. of vertices
        private List<int>[] adj; // Adjacency List

        // Constructor
        Graph(int v)
        {
            V = v;
            adj = new List<int>[v];
            for (int i = 0; i < v; ++i)
                adj[i] = new List<int>();
        }

        // Function to add an edge
        // into the graph
        void addEdge(int v, int w)
        {
            adj[v].Add(w);
            adj[w].Add(v);
        }

        // A recursive function that uses visited[]
        // and parent to detect cycle in subgraph
        // reachable from vertex v.
        bool isCyclicUtil(int v, bool[] visited,
                             int parent)
        {
            // Mark the current node as visited
            visited[v] = true;
            int i;

            // Recur for all the vertices
            // adjacent to this vertex
            foreach (int it in adj[v])
            {
                i = it;

                // If an adjacent is not visited,
                // then recur for that adjacent
                if (!visited[i])
                {
                    if (isCyclicUtil(i, visited, v))
                        return true;
                }

                // If an adjacent is visited and
                // not parent of current vertex,
                // then there is a cycle.
                else if (i != parent)
                    return true;
            }
            return false;
        }

        // Returns true if the graph
        // is a tree, else false.
        bool isTree()
        {
            // Mark all the vertices as not visited
            // and not part of recursion stack
            bool[] visited = new bool[V];
            for (int i = 0; i < V; i++)
                visited[i] = false;

            // The call to isCyclicUtil serves
            // multiple purposes. It returns true if
            // graph reachable from vertex 0 is cyclcic.
            // It also marks all vertices reachable from 0.
            if (isCyclicUtil(0, visited, -1))
                return false;

            // If we find a vertex which is not reachable
            // from 0 (not marked by isCyclicUtil(),
            // then we return false
            for (int u = 0; u < V; u++)
                if (!visited[u])
                    return false;

            return true;
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
                Console.WriteLine("Graph is Tree");
            else
                Console.WriteLine("Graph is not Tree");

        }
    }

}
