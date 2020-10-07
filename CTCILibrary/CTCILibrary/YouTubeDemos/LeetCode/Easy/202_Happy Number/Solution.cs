﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._202_Happy_Number
{
    /*
     * 
     * Write an algorithm to determine if a number n is "happy".

        A happy number is a number defined by the following process: Starting with any positive integer, replace the number by the sum of the squares of its digits, and repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1. Those numbers for which this process ends in 1 are happy numbers.

        Return True if n is a happy number, and False if not.

        Example: 

        Input: 19
        Output: true
        Explanation: 
        12 + 92 = 82
        82 + 22 = 68
        62 + 82 = 100
        12 + 02 + 02 = 1
     */
    public class Solution
    {
        public bool IsHappy(int n)
        {
            HashSet<long> sumSet = new HashSet<long>();
            long squareDigitSum = SquareDigitSum(n);
            while (!sumSet.Contains(squareDigitSum))
            {
                sumSet.Add(squareDigitSum);
                squareDigitSum = SquareDigitSum(squareDigitSum);
                if (squareDigitSum == 1)
                    return true;
            }

            return false;
        }

        private long SquareDigitSum(long n)
        {
            long sum = 0;
            while (n != 0)
            {
                int lastDigit = (int)n % 10;
                sum += (long)(lastDigit * lastDigit);
                n = n / 10;
            }
            return sum;
        }
    }
}
