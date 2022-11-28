using System;

namespace _5.ClimbingSteps
{
    class Program
    {
        public static int ClimbStairs(int n)
        {
            if (n <= 1)
                return n;
            int[] res = new int[n + 1];
            res[0] = 1;
            res[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                res[i] = res[i - 2] + res[i - 1];
            }
            return res[n];

            //if (n < 0)
            //{
            //    return 0;
            //}
            //else if (n == 1)
            //{
            //    return 1;
            //}
            //else
            //{
            //    int a = 0;
            //    int b = 1;
            //    int c = 0;
            //    for (int i = 0; i < n; i++)
            //    {
            //        c = a + b;
            //        a = b;
            //        b = c;
            //    }
            //    return c;
            //}
        }
            static void Main(string[] args)
        {
          int data = ClimbStairs(5);
            Console.WriteLine(data);
        }
    }
}
