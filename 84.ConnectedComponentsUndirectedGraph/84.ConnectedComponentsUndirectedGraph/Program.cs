using System;
using System.Collections.Generic;

namespace _84.ConnectedComponentsUndirectedGraph
{
    public class Graph
    {
        // A user define class to represent a graph. 
        // A graph is an array of adjacency lists. 
        // Size of array will be V (number of vertices 
        // in graph) 
        int V;
        List<int>[] adjListArray;

        // constructor 
        Graph(int V)
        {
            this.V = V;

            // define the size of array as 
            // number of vertices 
            adjListArray = new List<int>[V];

            // Create a new list for each vertex 
            // such that adjacent nodes can be stored 

            for (int i = 0; i < V; i++)
            {
                adjListArray[i] = new List<int>();
            }
        }

        // Adds an edge to an undirected graph 
        void addEdge(int src, int dest)
        {
            // Add an edge from src to dest. 
            adjListArray[src].Add(dest);

            // Since graph is undirected, add an edge from dest 
            // to src also 
            adjListArray[dest].Add(src);
        }

        void DFSUtil(int v, bool[] visited)
        {
            // Mark the current node as visited and print it 
            visited[v] = true;
            Console.Write(v + " ");

            // Recur for all the vertices 
            // adjacent to this vertex 
            foreach (int x in adjListArray[v])
            {
                if (!visited[x]) DFSUtil(x, visited);
            }

        }
        void connectedComponents()
        {
            int count = 0;
            // Mark all the vertices as not visited 
            bool[] visited = new bool[V];
            for (int v = 0; v < V; ++v)
            {
                if (!visited[v])
                {
                    // print all reachable vertices 
                    // from v 
                    DFSUtil(v, visited);
                    count++;
                    Console.WriteLine();
                }
            }
            Console.Write($"The total connected components are :" + count);
        }


        // Driver code 
        public static void Main(String[] args)
        {
            // Create a graph given in the above diagram  
            Graph g = new Graph(5); // 5 vertices numbered from 0 to 4  

            g.addEdge(0, 1);
            g.addEdge(1, 2);
            g.addEdge(3, 4);
            Console.WriteLine("Following are connected components");
            g.connectedComponents();
        }
    }
}
