using System;
using System.Collections.Generic;

namespace _117.CourseScheduleii
{
    class Program
    {
        public int[] FindOrder(int numCourses, int[][] prerequisites)
        {
            var adj = new List<int>[numCourses];
            for (int i = 0; i < numCourses; i++)
            {
                adj[i] = new List<int>();
            }
            int[] indegree = new int[numCourses];
            foreach (int[] pr in prerequisites)
            {
                int current = pr[0];
                int prereq = pr[1];
                indegree[current]++;
                adj[prereq].Add(current);
            }
            Queue<int> q = new Queue<int>();
            int[] list = new int[numCourses];
            for (int i = 0; i < indegree.Length; i++)
                if (indegree[i] == 0)
                    q.Enqueue(i);

            int cnt = 0;
            int j = 0;
            while (q.Count > 0)
            {

                int u = q.Dequeue();
                list[j++] = u;
                foreach (int itr in adj[u])
                {

                    if (--indegree[itr] == 0)
                        q.Enqueue(itr);
                    
                }
                
                cnt++;
            }
            if (cnt != numCourses)
            {

                return new int[] { }; 
            }
            else
                return list;
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
