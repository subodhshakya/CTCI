using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._392_Is_Subsequence
{
    class Solution
    {
        public bool IsSubsequence(string s, string t)
        {
            int sIndex = 0;
            int tIndex = 0;

            while (sIndex < s.Length && tIndex < t.Length)
            {
                if (s[sIndex] == t[tIndex])
                    sIndex++;

                tIndex++;
            }

            if (sIndex == s.Length)
                return true;

            return false;
        }
    }
}
