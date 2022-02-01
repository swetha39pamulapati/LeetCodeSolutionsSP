using System;

namespace _171.MedianOf2SortedArrays
{
    class Program
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {

            var mediumPositionLeft = (nums1.Length + nums2.Length - 1) / 2;
            var mediumPositionRight = (nums1.Length + nums2.Length) / 2;
            if (mediumPositionLeft < 0)
                return 0;
            var currentPosition = 0;
            var index1 = 0;
            var index2 = 0;
            var result = 0.0;
            while (currentPosition <= mediumPositionRight)
            {
                var nextNumber = 0;
                if (index1 >= nums1.Length)
                {
                    nextNumber = nums2[index2];
                    index2++;
                }
                else if (index2 >= nums2.Length)
                {
                    nextNumber = nums1[index1];
                    index1++;
                }
                else if (nums1[index1] < nums2[index2])
                {
                    nextNumber = nums1[index1];
                    index1++;
                }
                else
                {
                    nextNumber = nums2[index2];
                    index2++;
                }
                if (currentPosition == mediumPositionLeft)
                    result += nextNumber;
                if (currentPosition == mediumPositionRight)
                    result += nextNumber;

                currentPosition++;

            }
            return result / 2.0;

        }

        //public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        //{

        //    int n1 = nums1.Length;
        //    int n2 = nums2.Length;

        //    int[] nums3 = new int[n1 + n2];

        //    nums3 = mergeArrays(nums1, nums2);

        //    int n = nums3.Length;

        //    Array.Sort(nums3);

        //    if (n % 2 != 0)
        //        return (double)nums3[n / 2];

        //    return (double)(nums3[(n - 1) / 2] + nums3[n / 2]) / 2.0;

        //}

        //public int[] mergeArrays(int[] arr1, int[] arr2)
        //{

        //    int[] arr3 = new int[arr1.Length + arr2.Length];

        //    int i = 0, j = 0, n = 0;

        //    // Store elements of first array 
        //    while (i < arr1.Length)
        //        arr3[n++] = arr1[i++];

        //    // Store of second array 
        //    while (j < arr2.Length)
        //        arr3[n++] = arr2[j++];

        //    return arr3;

        //}
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 3 }; int[] nums2 = { 2 };
            Program p = new Program();
            double result =  p.FindMedianSortedArrays(nums1, nums2);
            Console.WriteLine(result);
        }
    }
}
