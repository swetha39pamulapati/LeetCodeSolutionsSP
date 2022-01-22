using System;

namespace _63.LongincreasingSequence
{
    class Program
    {
        public int BinarySearch(int[] a, int left, int right, int element)
        {
            while (right - left > 1)
            {
                int middle = (right + left) / 2;
                if (a[middle] >= element)
                    right = middle;
                else
                    left = middle;
            }
            return right;
        }
        public int LengthOfLIS(int[] nums)
        {
            int n = nums.Length;
            int len = 0;
            if (n > 0)
            {
                len = 1;
                int[] dp = new int[n];
                dp[0] = nums[0];
                for (int i = 1; i < n; i++)
                {
                    if (nums[i] < dp[0])
                        dp[0] = nums[i];
                    else if (nums[i] > dp[len - 1])
                        dp[len++] = nums[i];
                    else
                        dp[BinarySearch(dp, -1, len - 1, nums[i])] = nums[i];
                }
            }
            return len;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int[] nums = { 10, 9, 2, 5, 3, 7, 101, 18 };
            int data = p.LengthOfLIS(nums);
            Console.WriteLine(data);
        }
    }
}
