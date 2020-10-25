using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._387_First_Unique_Character_in_a_String
{
    class Solution
    {
        public int FirstUniqChar(string s)
        {
            // One of the way is to use char count map
            Dictionary<char, int> charCountMap = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (charCountMap.ContainsKey(c))
                    charCountMap[c]++;
                else
                    charCountMap[c] = 1;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (charCountMap[s[i]] == 1)
                    return i;
            }

            return -1;
        }
    }
}
