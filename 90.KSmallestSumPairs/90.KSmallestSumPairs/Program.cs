using System;
using System.Collections.Generic;
using System.Linq;

namespace _90.KSmallestSumPairs
{
    //https://leetcode.com/problems/find-k-pairs-with-smallest-sums/discuss/376162/C-O(kn)-Beating-100
    class Program
    {
        public IList<IList<int>> KSmallestPairs(int[] nums1, int[] nums2, int k)
        {
            var result = new List<IList<int>>();
            var index = new int[nums1.Length];
            int count = 0;
            while (count < k && count < nums1.Length * nums2.Length)
            {
               int  min = int.MaxValue;
                int minIndex = 0;
                for (int j = 0; j < index.Length; j++)
                {
                    if (index[j] >= nums2.Length) continue;
                    if (nums1[j] + nums2[index[j]] <= min)
                    {
                        min = nums1[j] + nums2[index[j]];
                        minIndex = j;
                    }
                }
                result.Add(new List<int> { nums1[minIndex], nums2[index[minIndex]] });
                index[minIndex]++;
                count++;
            }
            return result;
        }


        static void Main(string[] args)
        {
            int[] nums1 = { 1,7,11};
            int[] nums2 = { 2,4,6};
            Program p = new Program();
            IList<IList<int>> result = p.KSmallestPairs(nums1, nums2,3);
            foreach(List<int> data in result)
            {
                Console.Write("[");
                for (int i = 0; i<data.Count; i++)
                {

                    Console.Write(data[i] +" ");
                }
                Console.Write("]");
            }
        }
    }
}
