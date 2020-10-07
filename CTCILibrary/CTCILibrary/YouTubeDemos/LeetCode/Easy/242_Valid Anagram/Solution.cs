using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._242_Valid_Anagram
{
    /*
     * Given two strings s and t , write a function to determine if t is an anagram of s.

        Example 1:

        Input: s = "anagram", t = "nagaram"
        Output: true
        Example 2:

        Input: s = "rat", t = "car"
        Output: false
        Note:
        You may assume the string contains only lowercase alphabets.

        Follow up:
        What if the inputs contain unicode characters? How would you adapt your solution to such case?
     */
    public class Solution
    {
        public bool IsAnagram(string s, string t)
        {
            int[] charCount = new int[256];

            int sLength = 0;
            int tLength = 0;
            if (!string.IsNullOrEmpty(s))
                sLength = s.Length;
            if (!string.IsNullOrEmpty(t))
                tLength = t.Length;

            if (sLength != tLength)
                return false;

            foreach (char c in s)
            {
                charCount[(int)c] += 1;
            }

            foreach (char c in t)
            {
                charCount[(int)c] -= 1;
                if (charCount[(int)c] < 0)
                    return false;
            }

            return true;
        }
    }
}
