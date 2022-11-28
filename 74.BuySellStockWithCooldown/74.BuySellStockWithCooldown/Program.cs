using System;

namespace _74.BuySellStockWithCooldown
{
    class Program
    {
        public int MaxProfit(int[] prices)
        {

            if (prices.Length < 2) return 0;

            int[] hold = new int[prices.Length];
            int[] cash = new int[prices.Length];

            // First buy. To buy first share we need to substract share's price from our free cash. Since we have no cash yet, our cash balance is negative
            hold[0] = -prices[0];
            // We don't buy anything and thus have zero cash balance
            cash[0] = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                // Now we have two option, we prefer one which gives more free cash: 
                // to keep current position open, thus our free cash staying unchanged, or
                // to buy shares assuming we sold shares two steps back ie i - 2
                hold[i] = Math.Max(hold[i - 1], i > 1 ? cash[i - 2] - prices[i] : -prices[i]);
                // Here two options as well:
                // to skip current stock buy ie to stay in cash
                // to sell shares at price[i] we bought earlier 
                cash[i] = Math.Max(cash[i - 1], hold[i - 1] + prices[i]);
            }

            // We return max available cash
            return cash[prices.Length - 1];

            //if (prices == null || prices.Length <= 1) return 0;

            //int b0 = -prices[0], b1 = b0;
            //int s0 = 0, s1 = 0, s2 = 0;

            //for (int i = 1; i < prices.Length; i++)
            //{
            //    b0 = Math.Max(b1, s2 - prices[i]);
            //    s0 = Math.Max(s1, b1 + prices[i]);
            //    b1 = b0;
            //    s2 = s1;
            //    s1 = s0;
            //}
            //return s0;

        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int[] prices = { 1, 2, 3, 0, 2 };
          int result =   p.MaxProfit(prices);
            Console.WriteLine(result);
        }
    }
}
