using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._171_Excel_Sheet_Column_Number
{
    public class Solution
    {
        public int TitleToNumber(string s)
        {
            int convertedNumber = 0;
            int placeHolder = 0;
            for (int i = (s.Length - 1); i >= 0; i--)
            {
                char current = s[i];
                convertedNumber += (int)Math.Pow(26, placeHolder) * ((int)current - 'A' + 1);
                placeHolder++;
            }
            return convertedNumber;
        }
    }
}
