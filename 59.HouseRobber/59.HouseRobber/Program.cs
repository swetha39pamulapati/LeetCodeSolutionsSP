using System;

namespace _59.HouseRobber
{
    class Program
    {
        public int Rob(int[] nums)
        {
            int n = nums.Length;
            int[] dp = new int[n + 1];
            dp[0] = 0;
            dp[1] = nums[0];
            for(int i =1; i<n; i++)
            {
                dp[i + 1] = Math.Max(dp[i], dp[i - 1] + nums[i]);
            }
            return dp[n];
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int[] nums = { 1, 2, 3, 1 };
            int result = p.Rob(nums);
            Console.WriteLine(result);
        }
    }
}
