using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Medium._005_Longest_Palindromic_Substring
{
    /* Given a string s, return the longest palindromic substring in s.

        Example 1:

        Input: s = "babad"
        Output: "bab"
        Note: "aba" is also a valid answer.
        Example 2:

        Input: s = "cbbd"
        Output: "bb"
        Example 3:

        Input: s = "a"
        Output: "a"
        Example 4:

        Input: s = "ac"
        Output: "a"
 

        Constraints:

        1 <= s.length <= 1000
        s consist of only digits and English letters (lower-case and/or upper-case),
     */
    class Solution
    {
        /*
    We observe that a palindrome mirrors around its center. Therefore, a palindrome can be expanded from its center, and there are only 2n−1 such centers.

You might be asking why there are 2n−1 but not nn centers? The reason is the center of a palindrome can be in between two letters. Such palindromes have even number of letters (such as "abba") and its center are between the two 'b's.
    */
        public string LongestPalindrome(string s)
        {
            if (s == null || s.Length < 1) return string.Empty;
            if (s.Length == 1) return s;
            int start = 0, end = 0;
            int maxLength = 0;
            int maxIndex = -1;
            for (int i = 0; i < s.Length; i++)
            {
                int len1 = ExpandAroundCenter(s, i, i);
                int len2 = ExpandAroundCenter(s, i, i + 1);
                int len = Math.Max(len1, len2);
                if (len > maxLength)
                {
                    maxLength = len;
                    maxIndex = i;
                }
            }
            if (maxLength % 2 == 0)
            {
                return s.Substring(maxIndex - (maxLength / 2) + 1, maxLength);
            }
            else
            {
                return s.Substring(maxIndex - (maxLength / 2), maxLength);
            }
        }

        private int ExpandAroundCenter(String s, int left, int right)
        {
            int L = left, R = right;
            while (L >= 0 && R < s.Length && s[L] == s[R])
            {
                L--;
                R++;
            }
            return R - L - 1;
        }
    }
}
