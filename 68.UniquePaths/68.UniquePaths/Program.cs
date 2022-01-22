using System;

namespace _68.UniquePaths
{
    class Program
    {
        public int UniquePaths(int m, int n)
        {
            int[][] dp = new int[m][];
            // C# thing, as we cannot define int[][] dp = new int[m][n]; 
            for (int i = 0; i < m; i++)
            {
                dp[i] = new int[n];
            }
            for (int i = 0; i<dp.Length; i++)
            {
                dp[i][0] = 1;
            }
            for (int j = 0; j < dp[0].Length; j++)
            {
                dp[0][j] = 1;
            }
            for(int i = 1; i<dp.Length; i++)
            {
                for(int j = 1; j<dp[0].Length; j++)
                {
                    dp[i][j] = dp[i - 1][j] + dp[i][j - 1]; //cell to the above and left
                }
            }
            return dp[m - 1][n - 1];
        }
        static void Main(string[] args)
        {
            Program p = new Program();
           int data =  p.UniquePaths(3, 7);
            Console.WriteLine(data);
        }
    }
}
