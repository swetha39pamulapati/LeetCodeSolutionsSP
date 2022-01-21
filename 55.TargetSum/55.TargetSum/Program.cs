using System;
using System.Collections.Generic;

namespace _55.TargetSum
{
    class Program
    {
        int result = 0;
        public int FindTargetSumWays(int[] nums, int S)
        {
            if (nums.Length == 0)
                return result;
            helper(nums, 0, S);
            return result;
        }
        private void helper(int[] nums, int start, int target)
        {
            if (start == nums.Length && target == 0)
            {
                result++;
                return;
            }
            if (start >= nums.Length)
                return;

            helper(nums, start + 1, target - nums[start]);
            helper(nums, start + 1, target + nums[start]);
        }
        static void Main(string[] args)
        {
            int[] nums = { 1, 1, 1, 1, 1 };
            Program p = new Program();
            int result = p.FindTargetSumWays(nums, 3);
            Console.WriteLine(result);
        }
    }
}
