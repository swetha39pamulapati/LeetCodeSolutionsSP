using System;

namespace _61.CoinChange
{
    class Program
    {
        public int CoinChange(int[] coins, int amount)
        {

            if (coins == null || coins.Length == 0)
                return 0;
            // this array each position indicates we are trying for that amount
            int[] dp = new int[amount + 1];
            // fill the array with max value 
            Array.Fill(dp, amount + 1);
            //no of coins required to make $0 
            dp[0] = 0;

            // this loop fills the dp array 
            for (int i = 0; i < dp.Length; i++)
            {
                // check all the coins
                for (int j = 0; j < coins.Length; j++)
                {
                    //current coin is less than or equal to dp position
                    // suppose if we are filling for dp[3] and if coins[j] = 2
                    // we are trying to fill min of dp[3] or 1 + dp[1] 
                    if (coins[j] <= i)
                    {
                        dp[i] = Math.Min(dp[i], 1 + dp[i - coins[j]]);
                    }
                }
            }

            return ((dp[amount] > amount) ? -1 : dp[amount]);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int[] result = { 1, 2, 5 };
            int data = p.CoinChange(result, 11);
            Console.WriteLine(data);
        }
    }
}
