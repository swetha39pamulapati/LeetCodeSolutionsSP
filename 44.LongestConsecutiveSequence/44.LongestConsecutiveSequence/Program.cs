using System;
using System.Collections.Generic;

namespace _44.LongestConsecutiveSequence
{
    class Program
    {
        public static int LongestConsecutive(int[] nums)
        {
            var set = new HashSet<int>();
            
            int n = nums.Length;
            int longestSequence = 0;
            foreach(int num in nums)
            {
                set.Add(num);
            }
            for (int i = 0; i < nums.Length; i++)
            {
                int currentNum = nums[i];
                int sequenceLength = 1;
                if (!set.Contains(currentNum - 1))
                {

                    while (set.Contains(currentNum + 1))
                    {
                        currentNum += 1;
                        sequenceLength += 1;
                    }
                    longestSequence = Math.Max(longestSequence, sequenceLength);
                }
            }
            return longestSequence;
        }
        static void Main(string[] args)
        {
            int[] nums = { 100, 4, 200, 1, 3, 2 };
          int result =   LongestConsecutive(nums);
            Console.WriteLine(result);
        }
    }
}
