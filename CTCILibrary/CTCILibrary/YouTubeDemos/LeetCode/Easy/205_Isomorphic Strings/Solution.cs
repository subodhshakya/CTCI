using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._205_Isomorphic_Strings
{
    /*
     * 
     * Given two strings s and t, determine if they are isomorphic.

        Two strings are isomorphic if the characters in s can be replaced to get t.

        All occurrences of a character must be replaced with another character while preserving the order of characters. No two characters may map to the same character but a character may map to itself.

        Example 1:

        Input: s = "egg", t = "add"
        Output: true
        Example 2:

        Input: s = "foo", t = "bar"
        Output: false
        Example 3:

        Input: s = "paper", t = "title"
        Output: true
        Note:
        You may assume both s and t have the same length.
     */
    public class Solution
    {
        public bool IsIsomorphic(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            if (string.IsNullOrEmpty(s) && string.IsNullOrEmpty(t))
            {
                return true;
            }

            Dictionary<char, char> sMap = new Dictionary<char, char>();
            Dictionary<char, char> tMap = new Dictionary<char, char>();

            for (int i = 0; i < s.Length; i++)
            {
                char sChar = s[i];
                char tChar = t[i];
                if (!sMap.ContainsKey(sChar))
                    sMap[sChar] = tChar;

                if (sMap[sChar] != tChar)
                    return false;

                if (!tMap.ContainsKey(tChar))
                    tMap[tChar] = sChar;

                if (tMap[tChar] != sChar)
                    return false;
            }

            return true;
        }
    }
}
