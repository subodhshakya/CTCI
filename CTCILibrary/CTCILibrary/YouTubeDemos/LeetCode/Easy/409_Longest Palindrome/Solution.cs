using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._409_Longest_Palindrome
{
    class Solution
    {
        public int LongestPalindrome(string s)
        {
            int[] count = new int[256];
            int length = 0;
            foreach (char c in s)
            {
                count[c]++;
                if (count[c] == 2)
                {
                    length += 2;
                    count[c] = 0;
                }
            }
            return (length == s.Length ? length : length + 1);
        }
    }
}
