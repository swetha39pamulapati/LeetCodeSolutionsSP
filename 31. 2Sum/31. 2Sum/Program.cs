using System;
using System.Collections.Generic;

namespace _31._2Sum
{
    class Program
    {
        //public static List<int> sum(int[] arr, int val)
        //{
        //    List<int> data = new List<int>();
        //    for(int i = 0;i<arr.Length-1; i++)
        //    {
        //        if(arr[i] +arr[i+1] == val)
        //        {
        //            data.Add(i);
        //            data.Add(i + 1);
        //            break;
        //        }
        //    }
        //    return data;

        //}
        public static int[] sum(int[] nums, int target)
        {
            if (nums == null || nums.Length < 2)
                return new int[2];

            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(target - nums[i]))
                {
                    return new int[] { i, dic[target - nums[i]] };
                }
                else if (!dic.ContainsKey(nums[i]))
                    dic.Add(nums[i], i);
            }
            return new int[2];
        }
        static void Main(string[] args)
        {
            int[] arr = { 3,2,4};
           int[] result =  sum(arr, 6);
            for(int i = 0; i<result.Length; i++)
            Console.WriteLine(result[i]);
           

        }
    }
}
