public class Solution {
    public int MaxProfit(int[] prices) {
        int profit = 0;
        int min = prices[0];
        
       for(int i = 0; i < prices.Length; i ++)
       {
           profit = Math.Max(profit, prices[i] - min);
           min = Math.Min(min, prices[i]);
       }
       return profit;

    }
}
