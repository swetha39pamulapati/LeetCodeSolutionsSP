using System;

namespace _59.HouseRobber
{
    class Program
    {
        public int Rob(int[] nums)
        {
            int[] dp = new int[nums.Length + 1];
            dp[0] = 0;
            dp[1] = nums[0];
            for(int i =1; i<nums.Length; i++)
            {
                dp[i + 1] = Math.Max(dp[i], dp[i - 1] + nums[i]);
            }
            return dp[nums.Length];
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
