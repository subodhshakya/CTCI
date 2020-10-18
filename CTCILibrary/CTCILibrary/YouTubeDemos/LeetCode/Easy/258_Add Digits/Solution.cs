using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._258_Add_Digits
{
    class Solution
    {
        /*
         * Given a non-negative integer num, repeatedly add all its digits until the result has only one digit.

            Example:

            Input: 38
            Output: 2 
            Explanation: The process is like: 3 + 8 = 11, 1 + 1 = 2. 
                         Since 2 has only one digit, return it.
            Follow up:
            Could you do it without any loop/recursion in O(1) runtime?
         * 
         */
        public int AddDigits(int num)
        {
            return digSum(num);
        }

        static int digSum(int n)
        {
            if (n == 0)
                return 0;
            return (n % 9 == 0) ? 9 : (n % 9);
        }

        static int digSumWithLoop(int num)
        {
            while (num >= 10)
            {
                int temp = num;
                int digitSum = 0;
                while (temp > 0)
                {
                    digitSum += temp % 10;
                    temp = temp / 10;
                }
                num = digitSum;
            }
            return num;
        }
    }
}
