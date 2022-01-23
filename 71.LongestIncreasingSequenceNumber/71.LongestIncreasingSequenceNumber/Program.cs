using System;
using System.Linq;

namespace _71.LongestIncreasingSequenceNumber
{
    class Program
    {
        //https://leetcode.com/problems/number-of-longest-increasing-subsequence/discuss/147870/C%3A-Easy-to-understand-solution-with-explanation.-(Accepted)
        public int FindNumberOfLIS(int[] nums)
        {
            if (null == nums || nums.Length == 0) return 0;
            int[] lengthOfLisAtIndex = new int[nums.Length];   //Length of the Longest Increasing Subsequence which ends with nums[i].
            int[] numberOfLisAtIndex = new int[nums.Length];   //Number of the Longest Increasing Subsequence which ends with nums[i].

            for (int i = 0; i < nums.Length; i++)
            {
                lengthOfLisAtIndex[i] = 1;
                numberOfLisAtIndex[i] = 1;
            }

            for (int i = 1; i < nums.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (nums[j] < nums[i])
                    {
                        if (lengthOfLisAtIndex[j] + 1 > lengthOfLisAtIndex[i])
                        {
                            lengthOfLisAtIndex[i] = lengthOfLisAtIndex[j] + 1;
                            numberOfLisAtIndex[i] = numberOfLisAtIndex[j];
                        }
                        else if (lengthOfLisAtIndex[j] + 1 == lengthOfLisAtIndex[i])
                        {
                            numberOfLisAtIndex[i] += numberOfLisAtIndex[j];
                        }
                    }
                }
            }

            int maxlen = lengthOfLisAtIndex.Max();
            int ans = 0;
            for (int i = 0; i < lengthOfLisAtIndex.Length; i++)
                if (lengthOfLisAtIndex[i] == maxlen)
                    ans += numberOfLisAtIndex[i];

            return ans;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            int[] arr = { 1, 3, 5, 4, 7 };
            int data = p.FindNumberOfLIS(arr);
            Console.WriteLine(data);
        }
    }
}
