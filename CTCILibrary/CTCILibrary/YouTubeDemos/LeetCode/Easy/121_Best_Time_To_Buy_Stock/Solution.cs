using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._121_Best_Time_To_Buy_Stock
{
    public static class Solution
    {
        public static int MaxProfit(int[] prices)
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

        /// <summary>
        /// Using recursion (Brute-Force Approach)
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public static int MaxProfit2(int[] prices)
        {
            return Calculate(prices, 0);
        }

        public static int Calculate(int[] prices, int s)
        {
            if (s >= prices.Length)
                return 0;
            int max = 0;
            for (int start = s; start < prices.Length; start++)
            {
                int maxprofit = 0;
                for (int i = start + 1; i < prices.Length; i++)
                {
                    if (prices[start] < prices[i])
                    {
                        int profit = Calculate(prices, i + 1) + prices[i] - prices[start];
                        if (profit > maxprofit)
                            maxprofit = profit;
                    }
                }
                if (maxprofit > max)
                    max = maxprofit;
            }
            return max;
        }

        /// <summary>
        /// Using Peak Valley Approach. This is simple and easy to understand
        /// Time: O(n)
        /// Space: O(1)
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public static int MaxProfit2UsingPeakValleyApproach(int[] prices)
        {
            int i = 0;
            int valley = prices[0];
            int peak = prices[0];
            int maxprofit = 0;
            while (i < prices.Length - 1)
            {
                while (i < prices.Length - 1 && prices[i] >= prices[i + 1])
                    i++;
                valley = prices[i];
                while (i < prices.Length - 1 && prices[i] <= prices[i + 1])
                    i++;
                peak = prices[i];
                maxprofit += peak - valley;
            }
            return maxprofit;
        }
    }
}
