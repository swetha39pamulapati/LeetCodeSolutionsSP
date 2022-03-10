using System;
using System.Collections.Generic;

namespace _55.TargetSum
{
    class Program
    {
        
        int result = 0;
        public int FindTargetSumWays(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
                return result;
            backtrack(nums, 0, 0, target);
            return result;

        }
        private void backtrack(int[] nums, int start, int currSum, int target)
        {
            if (start == nums.Length)
            {
                if (currSum == target)
                    result++;
                return;
            }
            if (start >= nums.Length)
                return;
            backtrack(nums, start + 1, currSum - nums[start], target);
            backtrack(nums, start + 1, currSum + nums[start], target);
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
