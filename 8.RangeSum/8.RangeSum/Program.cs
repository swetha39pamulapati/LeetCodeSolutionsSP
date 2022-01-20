using System;

namespace _8.RangeSum
{
    class Program
    {
        int[] arr;
        public Program(int[] nums)
        {
            arr = new int[nums.Length];
            int sum = 0;
            for(int i = 0; i<nums.Length; i++)
            {
                sum = sum + nums[i];
                arr[i] = sum;
            }
        }
        public int SumRange(int left, int right)
        {
            int a = arr[right];
            int b = 0;
            if(left != 0)
            {
                b = arr[left - 1];
            }
            return a - b;
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
