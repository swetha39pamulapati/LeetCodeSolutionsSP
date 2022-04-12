using System;

namespace _8.RangeSum
{
    class Program
    {
        int[] sums;
        public Program(int[] nums)
        {
            var n = nums.Length;
            sums = new int[n + 1];
            sums[0] = 0;
            for (int i = 1; i <= n; i++)
            {
                sums[i] = sums[i - 1] + nums[i - 1];
            }
        }
        public int SumRange(int i, int j)
        {
            return sums[j + 1] - sums[i];
        }
        static void Main(string[] args)
        {
            int[] arr = { -2, 0, 3, -5, 2, -1 };
            Program p = new Program(arr);
            Console.WriteLine( p.SumRange(0, 2));
            Console.WriteLine(p.SumRange(2, 5));
            Console.WriteLine(p.SumRange(0, 5));
        }
    }
}
