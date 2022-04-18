using System;

namespace _17.MeetingRooms
{
    //Given an array of meeting time intervals consisting of start and end times [[s1,e1],[s2,e2],...] (si < ei), determine if a person could attend all meetings.
    public class Program
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
           for(int i = 0; i<starts.Length-1; i++)
            {
                if (starts[i + 1] < ends[i])
                    return false;
                
            }
            return true;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Interval[] data = new Interval[]
            {
               new Interval(0,30),
                new Interval(5,10),
                 new Interval(15,20),

                //new Interval(5,8),
                //new Interval(9,15),

            };

            bool result = p.canAttendAMetting(data);
            Console.WriteLine(result);

        }
    }
}
