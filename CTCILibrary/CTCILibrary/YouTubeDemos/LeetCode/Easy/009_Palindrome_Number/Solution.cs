using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._009_Palindrome_Number
{
    /*
     * Determine whether an integer is a palindrome. An integer is a palindrome when it reads the same backward as forward.

        Example 1:

        Input: 121
        Output: true
        Example 2:

        Input: -121
        Output: false
        Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
        Example 3:

        Input: 10
        Output: false
        Explanation: Reads 01 from right to left. Therefore it is not a palindrome.
        Follow up:

        Could you solve it without converting the integer to a string?
     * 
     * 
     */
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }
            else
            {
                return x == Reverse(x);
            }
        }

        public int Reverse(int n)
        {
            int rev = 0;
            while (n > 0)
            {
                int rem = n % 10;
                rev = rev * 10 + rem;
                n = n / 10;
            }
            return rev;
        }
    }
}
