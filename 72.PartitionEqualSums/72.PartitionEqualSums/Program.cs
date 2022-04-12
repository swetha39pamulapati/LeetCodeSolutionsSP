using System;
using System.Collections;

namespace _72.PartitionEqualSums
{
    //https://www.youtube.com/watch?v=3N47yKRDed0
    class Program
    {
        //public bool CanPartition(int[] nums)
        //{
        //    int total = 0;
        //    foreach (int i in nums)
        //        total += i;
        //    if (total % 2 != 0)
        //        return false;

        //    return CanPartition(nums, 0, 0, total, new Hashtable());
        //}
        //private bool CanPartition(int[] nums, int index, int sum, int total, Hashtable saved)
        //{
        //    string s = index.ToString() + "-" + sum.ToString();
        //    if (saved.Contains(s))
        //        return (bool)saved[s];

        //    if (sum == total / 2)
        //        return true;

        //    if (sum > total / 2 || index >= nums.Length)
        //        return false;

        //    bool result = CanPartition(nums, index + 1, sum + nums[index], total, saved) || CanPartition(nums, index + 1, sum, total, saved);

        //    if (!saved.Contains(s))
        //        saved.Add(s, result);

        //    return result;
        //}
        //
        public bool CanPartition(int[] nums)
        {
            int sum = 0;
            foreach (int i in nums)
                sum += i;
            if (sum % 2 != 0)
                return false;

            int len = nums.Length;
            int target = sum / 2;
            bool[] dp = new bool[target + 1];
            dp[0] = true;

            for (int i = 0; i < len; i++)
            {
                for (int j = target; j >= 0; j--)
                {
                    if (j >= nums[i] && dp[j - nums[i]])
                        dp[j] = true;
                }
            }
            return dp[target];
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int[] data = { 1, 5, 11, 5 };
            bool result = p.CanPartition(data);
            Console.WriteLine(result);
        }
    }
}
