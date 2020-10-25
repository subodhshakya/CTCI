using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._383_Ransom_Note
{
    class Solution
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            Dictionary<char, int> charCountMap = new Dictionary<char, int>();

            foreach (char c in ransomNote)
            {
                if (charCountMap.ContainsKey(c))
                {
                    charCountMap[c]++;
                }
                else
                    charCountMap[c] = 1;
            }

            foreach (char c in magazine)
            {
                if (charCountMap.ContainsKey(c))
                    charCountMap[c]--;
            }

            foreach (KeyValuePair<char, int> kvp in charCountMap)
            {
                if (kvp.Value > 0)
                    return false;
            }

            return true;
        }
    }
}
