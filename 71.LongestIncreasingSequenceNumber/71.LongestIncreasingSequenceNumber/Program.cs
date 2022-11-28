using System;
using System.Linq;

namespace _71.LongestIncreasingSequenceNumber
{//https://leetcode.com/problems/number-of-longest-increasing-subsequence/discuss/147870/C%3A-Easy-to-understand-solution-with-explanation.-(Accepted)
    class Program
    {
        public int FindNumberOfLIS(int[] nums)
        {
            if (nums.Length == 0)
                return 0;
            int[] dp = new int[nums.Length];
            int[] numberOfLisAtIndex = new int[nums.Length];
            Array.Fill(dp, 1);
            Array.Fill(numberOfLisAtIndex, 1);
            for (int i = 1; i < nums.Length; i++)
            {

                for (int j = 0; j < i; j++)
                {
                    if (nums[j] < nums[i])
                    {
                        if (dp[j] + 1 > dp[i])
                        {
                            dp[i] = dp[j] + 1;
                            numberOfLisAtIndex[i] = numberOfLisAtIndex[j];
                        }
                        else if (dp[j] + 1 == dp[i])
                        {
                            numberOfLisAtIndex[i] += numberOfLisAtIndex[j];
                        }
                    }
                }
            }
            int maxlen = dp.Max();
            int ans = 0;
            for (int k = 0; k < dp.Length; k++)
                if (dp[k] == maxlen)
                    ans += numberOfLisAtIndex[k];

            return ans;

        }

        static void Main(string[] args)
        {
            Program p = new Program();
            int[] arr = { 10, 9, 2, 5, 3, 7, 101, 18 };
            int data = p.FindNumberOfLIS(arr);
            Console.WriteLine(data);
        }
    }
}
