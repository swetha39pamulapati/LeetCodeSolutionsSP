using System;
using System.Collections.Generic;

namespace _117.CourseScheduleii
{
    class Program
    {
        private int[] _result;
        private int resultIndex = 0;
        public int[] FindOrder(int numCourses, int[][] prerequisites)
        {
            _result = new int[numCourses];

            var adjacencyMatrix = new HashSet<int>[numCourses];

            for (int i = 0; i < numCourses; i++)
            {
                adjacencyMatrix[i] = new HashSet<int>();
            }

            foreach (var fromTo in prerequisites)
            {
                var from = fromTo[0];
                var to = fromTo[1];

                adjacencyMatrix[from].Add(to);
            }

            var isVisited = new bool[numCourses];
            var isAdded = new bool[numCourses];

            for (int i = 0; i < numCourses; i++)
            {
                if (isAdded[i]) continue;
                var noCyclic = DFS(i, adjacencyMatrix, isVisited, isAdded);
                if (!noCyclic) return new int[0];
            }

            return _result;
        }
        private bool DFS(int cur, HashSet<int>[] adjacencyMatrix, bool[] isVisited, bool[] isAdded)
        {
            if (isVisited[cur]) return false;

            isVisited[cur] = true;
            var nextCourses = adjacencyMatrix[cur];

            foreach (var next in nextCourses)
            {
                var oneResult = DFS(next, adjacencyMatrix, isVisited, isAdded);
                if (!oneResult) return false;
            }

            if (!isAdded[cur])
            {
                _result[resultIndex] = cur;
                resultIndex++;
                isAdded[cur] = true;
            }

            isVisited[cur] = false;

            return true;
        }
        static void Main(string[] args)
        {
            int[][] matrix = new int[4][]
           {
                new int[]{ 1,0 },
                 new int[]{ 2,0 },
                  new int[]{ 3,1 },
                  new int[]{ 3,2 },

           };
            Program p = new Program();
            int[] result = p.FindOrder(4, matrix);
            Console.WriteLine(result.Length);
        }
    }
}
