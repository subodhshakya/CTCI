﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._231_Power_of_Two
{
    /*
     * 
     * Given an integer n, write a function to determine if it is a power of two.

 

        Example 1:

        Input: n = 1
        Output: true
        Explanation: 20 = 1
        Example 2:

        Input: n = 16
        Output: true
        Explanation: 24 = 16
        Example 3:

        Input: n = 3
        Output: false
        Example 4:

        Input: n = 4
        Output: true
        Example 5:

        Input: n = 5
        Output: false
 

        Constraints:

        -2^31 <= n <= 2^31 - 1
     * 
     */
    public class Solution
    {
        public bool IsPowerOfTwo(int n)
        {
            /*If a number is power of 2, then its highly bit is 1 and there is only one 1. Therefore, n & (n-1) is 0.*/
            return n > 0 && (n & n - 1) == 0;
        }
    }
}
