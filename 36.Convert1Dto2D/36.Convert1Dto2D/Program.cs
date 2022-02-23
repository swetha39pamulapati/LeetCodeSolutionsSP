using System;

namespace _36.Convert1Dto2D
{
    class Program
    {
        public static int[][] Construct2DArray(int[] original, int m, int n)
        {
            if (m * n != original.Length)
                return new int[0][];

            int[][] res = new int[m][];
            for (int i = 0; i < m; i++)
                res[i] = new int[n];

            for (int i = 0; i < original.Length; i++)
            {
                res[i / n][i % n] = original[i];
            }

            return res;
        }
        static void Main(string[] args)
        {
            int[] original = { 1, 2, 3, 4 };
            int m = 2;
            int n = 2;
            int [][] result = Construct2DArray(original, m, n);
            for(int i = 0; i<result.Length; i++)
            {
                for(int j = 0; j< result.Length; j++)
                {
                    Console.Write(result[i][j] + " ");

                }
                Console.WriteLine();
            }
        }
    }
}
