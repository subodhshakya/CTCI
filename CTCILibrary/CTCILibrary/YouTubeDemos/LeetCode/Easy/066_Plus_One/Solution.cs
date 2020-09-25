using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._066_Plus_One
{
    public static class Solution
    {
        public static int[] PlusOne(int[] digits)
        {
            int carry = 1;
            int[] sumArray = new int[digits.Length + 1];
            int sumIndex = digits.Length;
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                int current = digits[i];
                int sum = current + carry;
                if (sum > 9)
                {
                    current = sum % 10;
                    carry = 1;
                }
                else
                {
                    current = sum;
                    carry = 0;
                }
                sumArray[sumIndex] = current;
                digits[i] = current;
                sumIndex--;
            }
            if (carry > 0)
            {
                sumArray[0] = carry;
            }
            else
            {
                return digits;
            }
            return sumArray;
        }
    }
}
