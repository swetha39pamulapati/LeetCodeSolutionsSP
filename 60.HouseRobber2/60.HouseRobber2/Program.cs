using System;

namespace _60.HouseRobber2
{
    class Program
    {
        public int Rob(int[] nums)
        {
            int len = nums.Length;
            if (len == 0)
                return 0;
            if (len == 1)
                return nums[0];

            return Math.Max(Robbed(nums, 0, len - 2), Robbed(nums, 1, len - 1));
        }
        public int Robbed(int[] nums,int start,int end)
        {
            if (start == end)
                return nums[start];
            int[] dp = new int[nums.Length ];
            dp[start] = nums[start];
            dp[start+1] = Math.Max(nums[start], nums[start + 1]);
            for (int i = start + 2; i <= end; i++)
                dp[i] = Math.Max(dp[i - 1], dp[i - 2]+ nums[i]);

            return dp[end];
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int[] arr = { 1, 2, 3, 1 };
            int result = p.Rob(arr);
            Console.WriteLine(result);
        }
    }
}
