using System;

namespace _6.BuySellStock
{
    class Program
    {
        public static int buySellStock(int[] nums)
        {
            int maxProfit = 0;
            int min = int.MaxValue;
            
            for(int i = 0; i<nums.Length; i++)
            {
                if (nums[i] < min)
                {
                    min = nums[i];
                }
                else if (nums[i] - min > maxProfit)
                    maxProfit = nums[i] - min;

            }
            return maxProfit;
        }
        static void Main(string[] args)
        {
            int[] arr = { 7, 1, 5, 3, 6, 12 };
         int data =    buySellStock(arr);
            Console.WriteLine(data);
        }
    }
}
