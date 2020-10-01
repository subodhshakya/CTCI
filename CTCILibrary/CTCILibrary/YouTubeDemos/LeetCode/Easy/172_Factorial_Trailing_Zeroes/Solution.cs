using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._172_Factorial_Trailing_Zeroes
{
    /*
     * Given an integer n, return the number of trailing zeroes in n!.

        Follow up: Could you write a solution that works in logarithmic time complexity?
     * 
     */
    class Solution
    {
        public int TrailingZeroes(int n)
        {
            if (n < 0)
                return -1;

            int count = 0;
            for (long i = 5; n / i >= 1; i *= 5)
            {
                count += (int)(n / i);
            }

            return count;
        }

        public int TrailingZeroes1(int n)
        {
            if (n == 0 || n == 1)
                return 0;

            long factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            int trailingZerosCount = 0;
            while (factorial > 0)
            {
                int lastDigit = (int)(factorial % 10);
                if (lastDigit == 0)
                {
                    trailingZerosCount++;
                }
                else
                    break;

                factorial = factorial / 10;
            }
            return trailingZerosCount;
        }
    }
}
