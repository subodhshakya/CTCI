using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._067_Add_Binary
{
    public static class Solution
    {
        public static string AddBinary(string a, string b)
        {
            int lengthA = a.Length;
            int lengthB = b.Length;
            int maxLength = lengthA > lengthB ? lengthA : lengthB;
            string sumBinary = string.Empty;

            int carry = 0;
            for (int i = maxLength - 1; i >= 0; i--)
            {
                int sum = 0;
                if (lengthA > 0)
                {
                    sum += (int)Char.GetNumericValue(a[lengthA - 1]);
                    lengthA--;
                }

                if (lengthB > 0)
                {
                    sum += (int)Char.GetNumericValue(b[lengthB - 1]);
                    lengthB--;
                }

                sum += carry;
                if (sum > 1)
                {
                    carry = 1;
                    sumBinary = (sum % 2).ToString() + sumBinary;
                }
                else
                {
                    carry = 0;
                    sumBinary = sum.ToString() + sumBinary;
                }
            }
            if (carry == 1)
            {
                sumBinary = carry.ToString() + sumBinary;
            }
            return sumBinary;
        }
    }
}
