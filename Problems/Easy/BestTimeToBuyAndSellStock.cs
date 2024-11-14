namespace Problems.Easy
{
    public class BestTimeToBuyAndSellStock
    {
        public static int MaxProfit(int[] prices)
        {
            //Given price where prices[i] is price given stock on ith day
            //[7,1,5,3,6,4]
            // | |
            //min, and current max profit

            int currMin = prices[0];
            int maxProfit = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < currMin)
                {
                    currMin = prices[i];
                }
                else
                {
                    if (prices[i] - currMin > maxProfit)
                    {
                        maxProfit = prices[i] - currMin;
                    }
                }
            }
            return maxProfit;
        }
    }
}
