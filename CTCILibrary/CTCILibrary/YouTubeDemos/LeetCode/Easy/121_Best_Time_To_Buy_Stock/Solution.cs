using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._121_Best_Time_To_Buy_Stock
{
    class Solution
    {
        public int MaxProfit(int[] prices)
        {
            int maxProfit = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                for (int j = i + 1; j < prices.Length; j++)
                {
                    int currentProfit = prices[j] - prices[i];
                    if (currentProfit > 0 && currentProfit > maxProfit)
                    {
                        maxProfit = currentProfit;
                    }
                }
            }

            return maxProfit;
        }
    }
}
