using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._415_Add_Strings
{
    class Solution
    {
        public string AddStrings(string num1, string num2)
        {
            string sum = string.Empty;
            string shortStr = string.Empty;
            string longStr = string.Empty;

            if (num1.Length <= num2.Length)
            {
                shortStr = num1;
                longStr = num2;
            }
            else
            {
                shortStr = num2;
                longStr = num1;
            }

            int sIndex = shortStr.Length - 1;
            int lIndex = longStr.Length - 1;
            int carry = 0;
            while (sIndex >= 0)
            {
                int digitSum = (int)char.GetNumericValue(shortStr[sIndex]) + (int)char.GetNumericValue(longStr[lIndex]) + carry;
                carry = 0;
                if (digitSum > 9)
                {
                    carry = 1;
                    digitSum = digitSum % 10;
                }
                sum = digitSum + sum;
                sIndex--;
                lIndex--;
            }

            while (lIndex >= 0)
            {
                int digitSum = (int)char.GetNumericValue(longStr[lIndex]) + carry;
                carry = 0;
                if (digitSum > 9)
                {
                    carry = 1;
                    digitSum = digitSum % 10;
                }
                sum = digitSum + sum;
                lIndex--;
            }
            if (carry > 0)
                sum = carry + sum;

            return sum;
        }
    }
}
