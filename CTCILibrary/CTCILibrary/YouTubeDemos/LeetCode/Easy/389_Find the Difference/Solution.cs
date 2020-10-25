using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._389_Find_the_Difference
{
    class Solution
    {
        public char FindTheDifference(string s, string t)
        {
            Dictionary<char, int> charCountMap = new Dictionary<char, int>();

            if (!string.IsNullOrEmpty(s))
            {
                foreach (char c in s)
                {
                    if (charCountMap.ContainsKey(c))
                        charCountMap[c]++;
                    else
                        charCountMap[c] = 1;
                }
            }

            foreach (char c in t)
            {
                if (charCountMap.ContainsKey(c))
                {
                    charCountMap[c] -= 1;
                    if (charCountMap[c] < 0)
                        return c;
                }
                else
                    return c;
            }

            return t[0];
        }
    }
}
