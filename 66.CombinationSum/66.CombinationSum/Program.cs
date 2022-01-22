using System;

namespace _66.CombinationSum
{
    class Program
    {
		public int CombinationSum4(int[] nums, int target)
		{
			int[] dp = new int[target + 1];
			Array.Fill(dp, -1);
			return Solve(nums, dp, target);
		}

		public int Solve(int[] nums, int[] dp, int sum)
		{
			if (sum == 0)
				return 1;

			if (sum < 0)
				return int.MaxValue;

			if (dp[sum] != -1)
				return dp[sum];

			int ans = 0;

			for (int i = 0; i < nums.Length; i++)
			{
				int res = Solve(nums, dp, sum - nums[i]);
				if (res != int.MaxValue)
					ans += res;
			}

			dp[sum] = ans;
			return ans;
		}
	}

	// Solution 2 : Tabulation Approach
	public class Solution
	{
		public int CombinationSum4(int[] nums, int target)
		{
			int[] dp = new int[target + 1];
			dp[0] = 1;

			for (int i = 1; i <= target; i++)
			{
				foreach (var num in nums)
				{
					if (i >= num)
						dp[i] += dp[i - num];
				}
			}

			return dp[target];
		}
		static void Main(string[] args)
        {
			Program p = new Program();
			int[] nums = { 1, 2, 3 };
			int data = p.CombinationSum4(nums,4);
            Console.WriteLine(data);
        }
    }
}
