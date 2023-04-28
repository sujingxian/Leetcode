public class Solution {
    public int MaxProfit(int[] prices) {
        int i = 0;
        int j = 1;
        int profit =0;
        while(i <= j && j < prices.Length)
        {
            if(prices[j] > prices[i])
            {
                profit = profit + prices[j]-prices[i];
            }
            i = j;
            j++;
        }
        return profit;
    }
}
