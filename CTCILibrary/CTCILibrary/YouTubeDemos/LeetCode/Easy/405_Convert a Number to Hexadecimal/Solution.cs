using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._405_Convert_a_Number_to_Hexadecimal
{
    class Solution
    {
        public string ToHex(int num)
        {
            if (num == 0)
                return "0";
            string hex = string.Empty;
            while (num != 0)
            {
                int rem = num & 15;
                hex = GetHex(rem) + hex;
                num = (int)((uint)num >> 4); // rightshift by filling 0 on left
            }

            return hex;
        }

        private string GetHex(int num)
        {
            string hex = string.Empty;
            if (num == 10)
                hex = "a";
            else if (num == 11)
                hex = "b";
            else if (num == 12)
                hex = "c";
            else if (num == 13)
                hex = "d";
            else if (num == 14)
                hex = "e";
            else if (num == 15)
                hex = "f";
            else
                hex = num.ToString();

            return hex;
        }
    }
}
