using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._263_Ugly_Number
{
    /*
     * Write a program to check whether a given number is an ugly number.

        Ugly numbers are positive numbers whose prime factors only include 2, 3, 5.
     */
    class Solution
    {
        public bool IsUgly(int num)
        {
            if (num == 0)
                return false;
            num = maxDivide(num, 2);
            num = maxDivide(num, 3);
            num = maxDivide(num, 5);

            return (num == 1) ? true : false;
        }

        public int maxDivide(int a, int b)
        {
            while (a % b == 0)
                a = a / b;
            return a;
        }
    }
}
