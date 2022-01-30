using System;



namespace _138.SortColors
{
    class Program
    {
        public void SortColors(int[] nums)
        {
            if (nums.Length == 0 || nums.Length == 1)
                return;
            int start = 0;
            int index = 0;
            int end = nums.Length - 1;
            while (index <= end && start < end)
            {
                if (nums[index] == 0)
                {
                    nums[index] = nums[start];
                    nums[start] = 0;
                    start++;
                    index++;
                }
                else if (nums[index] == 2)
                {
                    nums[index] = nums[end];
                    nums[end] = 2;
                    end--;
                }
                else
                {
                    index++;
                }
            }
            for(int i = 0; i<nums.Length; i++)
            Console.WriteLine(nums[i]);

        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int[] nums = { 2, 0, 2, 1, 1, 0 };
            p.SortColors(nums);
            Console.WriteLine("Hello World!");
        }
    }
}
