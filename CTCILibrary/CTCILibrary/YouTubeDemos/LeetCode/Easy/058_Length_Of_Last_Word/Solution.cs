using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._058_Length_Of_Last_Word
{
    class Solution
    {
        public int LengthOfLastWord(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            int previousLength = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i != 0 && s[i - 1] == ' ' && s[i] != ' ')
                {
                    previousLength = 0;
                }
                if (s[i] != ' ')
                    previousLength++;
            }
            return previousLength;
        }
    }
}
