using System;

namespace _73.PartitionEqualKsum
{
    class Program
    {
        //https://www.youtube.com/watch?v=mBk4I0X46oI
        public bool CanPartitionKSubsets(int[] nums, int k)
        {
            if (k <= 0)
            {
                return false;
            }
            int sumK = 0;
            foreach (int i in nums)
                sumK += i;
            // Sum has to be divisible by k
            if (sumK % k != 0)
            {
                return false;
            }
            return Search(nums, sumK / k, 0, 0, k, new bool[nums.Length]);
        }
        private bool Search(int[] nums, int sumK, int curSumK, int currentIndex, int k, bool[] numUsed)
        {
            // K - 1 buckets already filled with numbers with sum == sumK
            if (k == 1)
            {
                return true;
            }

            // if we found the first sum, try to check if we can k-1 sums
            if (sumK == curSumK)
            {
                return Search(nums, sumK, 0, 0, k - 1, numUsed);
            }

            // try each number to form the sum
            for (var index = currentIndex; index < nums.Length; ++index)
            {
                if (numUsed[index])
                {
                    continue;
                }
                if (curSumK + nums[index] <= sumK)
                {
                    numUsed[index] = true;
                    // we havn't formed a partition yet
                    if (Search(nums, sumK, curSumK + nums[index], index + 1, k, numUsed))
                    {
                        return true;
                    }
                    numUsed[index] = false;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int[] arr = { 4, 3, 2, 3, 5, 2, 1 };
           bool result =  p.CanPartitionKSubsets(arr,4);
            Console.WriteLine(result);
        }
    }
}
