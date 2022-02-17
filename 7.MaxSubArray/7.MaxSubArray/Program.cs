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

            for (int i = 0; i < nums.Length; i++)
            {
                interval = Math.Max(nums[i], interval + nums[i]);
                ans = Math.Max(ans, interval);
            }
            return ans;
        
    }
           

        static void Main(string[] args)
        {
            int[] arr = { 5, 4, -1, 7, 8 };
            
           int data = maxSubArray(arr);
            Console.WriteLine(data);
        }
    }
}
