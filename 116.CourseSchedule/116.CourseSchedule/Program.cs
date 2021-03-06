using System;
using System.Collections.Generic;

namespace _116.CourseSchedule
{
    //https://www.youtube.com/watch?v=EgI5nU9etnU
    class Program
    {
        public bool CanFinish(int numCourses, int[][] prerequisites)
        {

            List<int>[] arr = new List<int>[numCourses];
            bool[] visited = new bool[numCourses];
            bool[] tmpVisited = new bool[numCourses];

            for (int i = 0; i < numCourses; ++i)
            {
                arr[i] = new List<int>();
            }

            for (int i = 0; i < prerequisites.GetLength(0); ++i)
            {
                arr[prerequisites[i][1]].Add(prerequisites[i][0]);
            }

            for (int i = 0; i < numCourses; ++i)
            {
                if (!Visit(arr, visited, tmpVisited, i))
                    return false;
            }

            return true;
        }

        private bool Visit(List<int>[] graph, bool[] visited, bool[] tmpVisited, int node)
        {
            if (tmpVisited[node])
                return false;
            if (visited[node])
                return true;

            tmpVisited[node] = true;

            foreach (int n in graph[node])
            {
                if (!Visit(graph, visited, tmpVisited, n))
                    return false;
            }

            tmpVisited[node] = false;
            visited[node] = true;
            return true;
        }
        static void Main(string[] args)
        {
            int[][] matrix = new int[1][]
          {
                new int[]{ 1,0 }
                

          };
            Program p = new Program();
            bool result = p.CanFinish(2, matrix);
            Console.WriteLine(result);
        }
    }
}
