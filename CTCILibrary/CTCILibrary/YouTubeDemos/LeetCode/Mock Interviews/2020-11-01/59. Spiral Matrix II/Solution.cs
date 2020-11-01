using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Mock_Interviews._2020_11_01._59._Spiral_Matrix_II
{
    /* Given a positive integer n, generate a square matrix filled with elements from 1 to n2 in spiral order.

        Example:

        Input: 3
        Output:
        [
         [ 1, 2, 3 ],
         [ 8, 9, 4 ],
         [ 7, 6, 5 ]
        ]     
     * 
     */
    class Solution
    {
        public int[][] GenerateMatrix(int n)
        {
            int[][] result = new int[n][];
            for (int i = 0; i < n; i++)
            {
                result[i] = new int[n];
            }
            int cnt = 1;
            for (int layer = 0; layer < (n + 1) / 2; layer++)
            {
                // direction 1 - traverse from left to right
                for (int ptr = layer; ptr < n - layer; ptr++)
                {
                    result[layer][ptr] = cnt++;
                }
                // direction 2 - traverse from top to bottom
                for (int ptr = layer + 1; ptr < n - layer; ptr++)
                {
                    result[ptr][n - layer - 1] = cnt++;
                }
                // direction 3 - traverse from right to left
                for (int ptr = layer + 1; ptr < n - layer; ptr++)
                {
                    result[n - layer - 1][n - ptr - 1] = cnt++;
                }
                // direction 4 - traverse from bottom to top
                for (int ptr = layer + 1; ptr < n - layer - 1; ptr++)
                {
                    result[n - ptr - 1][layer] = cnt++;
                }
            }
            return result;
        }
    }
}
