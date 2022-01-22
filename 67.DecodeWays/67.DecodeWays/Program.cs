using System;

namespace _67.DecodeWays
{
    class Program
    {
        public int NumDecodings(string s)
        {
            int[] dp = new int[s.Length + 1];
            dp[0] = 1;
            dp[1] = s[0] == '0' ? 0 : 1;
            for(int i = 2; i < dp.Length; i++)
            {
                int oneDigit = Convert.ToInt32(s.Substring(i - 1, 1));
                int twoDigit = Convert.ToInt32(s.Substring(i - 2, 2));
                if (oneDigit > 0)
                {
                    dp[i] += dp[i - 1];
                }
                if(twoDigit>=10 && twoDigit <= 26)
                {
                    dp[i] += dp[i - 2];
                }
            }
            return dp[s.Length];
        }
        static void Main(string[] args)
        {
            Program p = new Program();
          int data =   p.NumDecodings("226");
            Console.WriteLine(data);
        }
    }
}
