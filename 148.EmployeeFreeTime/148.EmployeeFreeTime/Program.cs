using System;
using System.Collections.Generic;

namespace _148.EmployeeFreeTime
{
       
    class Program
    {
        public class Interval
        {
          public  int start;
            public int end;

            public Interval(int start, int end)
            {
                this.start = start;
                this.end = end;
            }

        }
        public  IList<Interval> employeeFreeTime(IList<IList<Interval>> avails)
        {
            IList<Interval> result = new List<Interval>();
            IList<Interval> timeLine = new List<Interval>();
            foreach(List<Interval> data in avails)
            {
                ((List<Interval>)timeLine).AddRange(data);
            }
            avails.forEach(e => ((List<Interval>)timeLine).AddRange(e));
           timeLine.Sort(((a, b) => a.start - b.start));

            Interval temp = timeLine[0];
            foreach (Interval each in timeLine)
            {
                if (temp.end < each.start)
                {
                    result.Add(new Interval(temp.end, each.start));
                    temp = each;
                }
                else
                {
                    temp = temp.end < each.end ? each : temp;
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            IList<IList<int>> result = new List<IList<int>>();
         
            Console.WriteLine("Hello World!");
        }
    }
}
