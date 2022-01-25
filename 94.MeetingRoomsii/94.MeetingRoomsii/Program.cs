using System;

namespace _94.MeetingRoomsii
{
    //https://www.youtube.com/watch?v=FdzJmTCVyJU
    class Program
    {
        public class Interval
        {
            public int start, end;
            public Interval(int s, int e)
            {
                start = s; end = e;
            }
        }
        public int minMeetingRooms(Interval[] intervals)
        {
            int n = intervals.Length;
            int[] start = new int[n];
            int[] end = new int[n];
            for (int k = 0; k < n; k++)
            {
                start[k] = intervals[k].start;
                end[k] = intervals[k].end;
            }
            Array.Sort(start);
            Array.Sort(end);
            int i = 0, j = 0, res = 0;
            while (i < n)
            {
                if (start[i] < end[j]) i++;
                else if (start[i] > end[j]) j++;
                else
                {
                    i++;
                    j++;
                }
                res = Math.Max(res, i - j);
            }
            return res;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Interval[] data = new Interval[]
            {
               new Interval(0,30),
                new Interval(5,10),
                 new Interval(15,20),
            };
            int result = p.minMeetingRooms(data);
            Console.WriteLine(result);
        }
    }
}
