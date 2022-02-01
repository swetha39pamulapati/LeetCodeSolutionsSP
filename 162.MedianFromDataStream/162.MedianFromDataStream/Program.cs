using System;
using System.Collections.Generic;

namespace _162.MedianFromDataStream
{
    public class MedianFinder
    {
        List<double> li = new List<double>();
        public MedianFinder()
        {

        }

        public void AddNum(int num)
        {
            int l = 0, r = li.Count;
            while (l < r)
            {
                int m = l + (r - l) / 2;
                if (li[m] < num)
                    l = m + 1;
                else
                    r = m;
            }
            li.Insert(l, num);
        }

        public double FindMedian()
        {
            int n = li.Count / 2;
            return li.Count % 2 == 0 ? (li[n] + li[n - 1]) / 2 : li[n];
        }
    
    static void Main(string[] args)
        {
            MedianFinder p = new MedianFinder();
            p.AddNum(1);
            p.AddNum(2);
            double data =  p.FindMedian();
            Console.WriteLine(data);
            p.AddNum(3);
            double result =  p.FindMedian();
            Console.WriteLine(result);
        }
    }
}
