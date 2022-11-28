using System;

namespace _61.CoinChange
{
    class Program
    {
        public int CoinChange(int[] coins, int amount)
        {

            var dp = Recurse(coins, amount, 0);
            return dp[amount] <= amount ? dp[amount] : -1;
        }

        public int[] Recurse(int[] coins, int amount, int index)
        {
            if (coins == null || coins.Length <= index)
            {
                int[] dp = new int[amount + 1];
                Array.Fill(dp, amount + 1);
                dp[0] = 0;
                return dp;
            }
            else
            {
                var dp = Recurse(coins, amount, index + 1);
                int coin = coins[index];
                for (int i = coin; i < dp.Length; i++)
                {
                    dp[i] = Math.Min(dp[i], 1 + dp[i - coin]);
                }

                return dp;
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int[] result = { 1,2,5 };
            int data = p.CoinChange(result, 11);
            Console.WriteLine(data);
        }
    }
}
