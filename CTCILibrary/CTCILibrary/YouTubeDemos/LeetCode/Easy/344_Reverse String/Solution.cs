using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._344_Reverse_String
{
    class Solution
    {
        public void ReverseString(char[] s)
        {
            if (s.Length > 0)
            {
                int first = 0;
                int last = s.Length - 1;
                while (first < last)
                {
                    char temp = s[first];
                    s[first] = s[last];
                    s[last] = temp;
                    first++;
                    last--;
                }
            }
        }
    }
}
