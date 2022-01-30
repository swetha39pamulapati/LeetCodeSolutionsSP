using System;

namespace _136._3SumClosest
{
    class Program
    {
        
            public int ThreeSumClosest(int[] nums, int target)
            {
                int result = nums[0] + nums[1] + nums[nums.Length - 1];
                Array.Sort(nums);
                for (int i = 0; i < nums.Length - 2; i++)
                {
                    int a_pointer = i + 1;
                    int b_pointer = nums.Length - 1;
                    while (a_pointer < b_pointer)
                    {
                        int current_sum = nums[i] + nums[a_pointer] + nums[b_pointer];
                        if (current_sum > target)
                        {
                            b_pointer--;
                        }
                        else
                        {
                            a_pointer++;
                        }
                        if (Math.Abs(current_sum - target) < Math.Abs(result - target))
                            result = current_sum;
                    
                }
                return result;
            }
        }
        static void Main(string[] args)
        {
            int[] nums = { -1, 2, 1, -4 };
            Program p = new Program();
            int result = p.ThreeSumClosest(nums,1);
            Console.WriteLine(result);
        }
    }
}
