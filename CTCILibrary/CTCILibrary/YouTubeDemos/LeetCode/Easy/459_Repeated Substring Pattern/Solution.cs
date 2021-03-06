﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._459_Repeated_Substring_Pattern
{
    class Solution
    {
        /*
        1> The length of the repeating substring must be a divisor of the length of the input string
        2> Search for all possible divisor of str.length, starting for length/2
        3> If i is a divisor of length, repeat the substring from 0 to i the number of times i is contained in s.length
        4> If the repeated substring is equals to the input str return true
    
        */
        public bool RepeatedSubstringPattern(string s)
        {
            int l = s.Length;
            for (int i = l / 2; i >= 1; i--)
            {
                if (l % i == 0)
                {
                    int m = l / i;
                    String subS = s.Substring(0, i);
                    StringBuilder sb = new StringBuilder();
                    for (int j = 0; j < m; j++)
                    {
                        sb.Append(subS);
                    }
                    if (sb.ToString().Equals(s)) return true;
                }
            }
            return false;
        }
    }
}
