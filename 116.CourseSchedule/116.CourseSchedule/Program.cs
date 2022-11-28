using System;
using System.Collections.Generic;

namespace _116.CourseSchedule
{
    //https://www.youtube.com/watch?v=rG2-_lgcZzo
    class Program
    {
        public bool CanFinish(int numCourses, int[][] prerequisites)
        {
            var adj = new List<int>[numCourses];
            for(int i = 0; i<numCourses; i++)
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
            for (int i = 0; i < indegree.Length; i++)
                if (indegree[i] == 0)
                    q.Enqueue(i);

            int cnt = 0;
            while (q.Count > 0)
            {

                int u = q.Dequeue();
                foreach (int itr in adj[u])
                {

                    if (--indegree[itr] == 0)
                        q.Enqueue(itr);
                }

                cnt++;
            }
            if (cnt != numCourses)
            {
                
                return false;
            }
            else
                return true;
        }

        static void Main(string[] args)
        {
            int[][] matrix = new int[1][]
          {
                new int[]{ 1,0 }
                //new int[]{ 2,1 },
                //new int[]{ 2,3},
                //new int[]{ 3,2 }

          };
            Program p = new Program();
            bool result = p.CanFinish(2, matrix);
            Console.WriteLine(result);
        }
    }
}
