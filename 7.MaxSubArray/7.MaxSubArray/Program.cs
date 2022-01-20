using System;

namespace _7.MaxSubArray
{
    class Program
    {
        public static int maxSubArray(int[] nums)
        {
            if (nums == null)
                return 0;
            int ans = nums[0];
            // Kadane's algorithm
            int interval = 0;

            for (int i = 0; i < nums.Length; ++i)
            {
                interval += nums[i];
                ans = Math.Max(interval, ans);
                interval = Math.Max(0, interval);
            }
            return ans;
        
    }
           

        static void Main(string[] args)
        {
            int[] arr = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            
           int data = maxSubArray(arr);
            Console.WriteLine(data);
        }
    }
}
