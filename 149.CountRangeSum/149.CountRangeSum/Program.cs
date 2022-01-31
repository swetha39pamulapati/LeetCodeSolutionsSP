using System;
using System.Collections.Generic;

namespace _149.CountRangeSum
{
    class Program
    {
        public int CountRangeSum(int[] nums, int lower, int upper)
        {
            mergeSort(nums, 0, nums.Length - 1, lower, upper);

            return total;
        }
        int total = 0;
        // (sorted prefix sum, sorted suffix sum, total sum
        private (List<long>, List<long>, long) mergeSort(int[] nums, int start, int end, int lower, int upper)
        {
            if (start == end)
            {
                int sum = nums[start];
                if (sum >= lower && sum <= upper)
                {
                    total++;
                }

                return (new List<long>() { sum }, new List<long>() { sum }, sum);
            }

            int mid = (start + end) / 2;

            var (lprefix, lsuffix, lsum) = mergeSort(nums, start, mid, lower, upper);
            var (rprefix, rsuffix, rsum) = mergeSort(nums, mid + 1, end, lower, upper);
            int nleft = mid - start + 1;
            int nright = end - mid;

            int i = 0, j = nright - 1;
            int ngtlower = 0; // number of greater than lower bound
            int count = 0;
            while (i < nleft && j >= 0)
            {
                // count pairs that is greater than lower
                if (lsuffix[i] + rprefix[j] >= lower)
                {
                    count++;
                    j--;
                }
                else
                {
                    ngtlower += count;
                    i++;
                }
            }
            while (i < nleft) { ngtlower += count; i++; }


            i = 0; j = nright - 1;
            int ngtuppger = 0; // number of greater than upper bound
            count = 0;
            while (i < nleft && j >= 0)
            {
                // count pairs that is greater than upper
                if (lsuffix[i] + rprefix[j] > upper)
                {
                    count++;
                    j--;
                }
                else
                {
                    ngtuppger += count;
                    i++;
                }
            }

            while (i < nleft) { ngtuppger += count; i++; }

            int ninrange = ngtlower - ngtuppger;
            total += ninrange;


            // construct suffix and prefix

            for (i = 0; i < lsuffix.Count; i++)
            {
                lsuffix[i] += rsum;
            }
            // merge lsuffix and rsuffix
            var suffix = mergeTwoList(lsuffix, rsuffix);

            for (i = 0; i < rprefix.Count; i++)
            {
                rprefix[i] += lsum;
            }

            var prefix = mergeTwoList(lprefix, rprefix);

            return (prefix, suffix, lsum + rsum);
        }

        private List<long> mergeTwoList(List<long> left, List<long> right)
        {
            int i = 0, j = 0;
            int nleft = left.Count;
            int nright = right.Count;
            var res = new List<long>();
            while (i < nleft && j < nright)
            {
                if (left[i] <= right[j])
                {
                    res.Add(left[i]);
                    i++;
                }
                else
                {
                    res.Add(right[j]);
                    j++;
                }
            }

            while (i < nleft) { res.Add(left[i++]); }
            while (j < nright) { res.Add(right[j++]); }

            return res;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int[] nums = { -2, 5, -1 };
            int lower = -2;
            int upper = 2;
           int result =  p.CountRangeSum(nums, lower, upper);
            Console.WriteLine(result);
        }
    }
}
