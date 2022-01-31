using System;
using System.Collections.Generic;
using System.Linq;

namespace _156.CourseScheduleiii
{
    class Program
    {
        //https://www.youtube.com/watch?v=ey8FxYsFAMU
        public int ScheduleCourse(int[][] courses)
        {
            Array.Sort(courses, (a, b) => a[1] - b[1]);
            var sortedDurations = new SortedList<int, int>();
            int time = 0;
            int count = 0;

            foreach (var course in courses)
            {
                if (time + course[0] <= course[1])
                {
                    if (!sortedDurations.ContainsKey(course[0]))
                        sortedDurations.Add(course[0], 1);
                    else
                        sortedDurations[course[0]]++;

                    time += course[0];
                    count++;
                }
                else if (sortedDurations.Count > 0 && sortedDurations.Last().Key > course[0])
                {
                    var maxDuration = sortedDurations.Last();
                    time += course[0] - maxDuration.Key;

                    if (maxDuration.Value == 1)
                        sortedDurations.Remove(maxDuration.Key);
                    else
                        sortedDurations[maxDuration.Key]--;

                    if (!sortedDurations.ContainsKey(course[0]))
                        sortedDurations.Add(course[0], 1);
                    else
                        sortedDurations[course[0]]++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int[][] matrix = new int[4][]
            {
                new int[]{ 100,200},
                 new int[]{ 200,1300 },
                  new int[]{ 1000,1250 },
                  new int[]{ 2000,3200 },


            };
           int data = p.ScheduleCourse(matrix);
            Console.WriteLine(data);
        }
    }
}
