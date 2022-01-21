using System;

namespace _17.MeetingRooms
{
  
  public  class Program
    {
        public class Interval
        {
           public int start, end;
           public Interval(int s, int e)
            {
                start = s; end = e;
            }
        }

        public bool canAttendAMetting(Interval[] intervals)
        {
            int[] starts = new int[intervals.Length];
            int[] ends = new int[intervals.Length];
            for(int  i = 0; i<intervals.Length; i++)
            {
                starts[i] = intervals[i].start;
                ends[i] = intervals[i].end;
            }
            Array.Sort(starts);
            Array.Sort(ends);
           for(int i = 1; i<starts.Length; i++)
            {
                //i=0; for this the array out of bound exception occurs so take from 1 and compare with previous.
                //if (starts[i + 1] < ends[i])
                //    return false;
                if (ends[i - 1] > starts[i])
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Interval[] data = new Interval[]
            {
               //new Interval(0,30),
               // new Interval(5,10),
               //  new Interval(15,20),

                new Interval(5,8),
                new Interval(9,15),

            };

            bool result = p.canAttendAMetting(data);
            Console.WriteLine(result);

        }
    }
}
