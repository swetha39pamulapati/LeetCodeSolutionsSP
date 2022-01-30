using System;

namespace _139.ContainerWithMostWater
{
    //https://www.youtube.com/watch?v=6PrIRPpTI9Q
    class Program
    {
        public int MaxArea(int[] height)
        {
            int maxArea = 0;
            int a_pointer = 0;
            int b_pointer = height.Length - 1;
            while (a_pointer < b_pointer)
            {
                if (height[a_pointer] < height[b_pointer])
                {
                    maxArea = Math.Max(maxArea, height[a_pointer] * (b_pointer - a_pointer));
                    a_pointer++;
                }
                else
                {
                    maxArea = Math.Max(maxArea, height[b_pointer] * (b_pointer - a_pointer));
                    b_pointer--;
                }
            }
            return maxArea;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int[] height = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
           int data = p.MaxArea(height);
            Console.WriteLine(data);
        }
    }
}
