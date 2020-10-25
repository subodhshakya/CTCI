using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Medium._008_String_to_Integer__atoi_
{
    /*  Implement atoi which converts a string to an integer.

        The function first discards as many whitespace characters as necessary until the first non-whitespace character is found. Then, starting from this character takes an optional initial plus or minus sign followed by as many numerical digits as possible, and interprets them as a numerical value.

        The string can contain additional characters after those that form the integral number, which are ignored and have no effect on the behavior of this function.

        If the first sequence of non-whitespace characters in str is not a valid integral number, or if no such sequence exists because either str is empty or it contains only whitespace characters, no conversion is performed.

        If no valid conversion could be performed, a zero value is returned.

        Note:

        Only the space character ' ' is considered a whitespace character.
        Assume we are dealing with an environment that could only store integers within the 32-bit signed integer range: [−231,  231 − 1]. If the numerical value is out of the range of representable values, INT_MAX (231 − 1) or INT_MIN (−231) is returned.
 

        Example 1:

        Input: str = "42"
        Output: 42
        Example 2:

        Input: str = "   -42"
        Output: -42
        Explanation: The first non-whitespace character is '-', which is the minus sign. Then take as many numerical digits as possible, which gets 42.
        Example 3:

        Input: str = "4193 with words"
        Output: 4193
        Explanation: Conversion stops at digit '3' as the next character is not a numerical digit.
        Example 4:

        Input: str = "words and 987"
        Output: 0
        Explanation: The first non-whitespace character is 'w', which is not a numerical digit or a +/- sign. Therefore no valid conversion could be performed.
        Example 5:

        Input: str = "-91283472332"
        Output: -2147483648
        Explanation: The number "-91283472332" is out of the range of a 32-bit signed integer. Thefore INT_MIN (−231) is returned.
 

        Constraints:

        0 <= s.length <= 200
        s consists of English letters (lower-case and upper-case), digits, ' ', '+', '-' and '.'.
     * 
     */
    public class Solution
    {
        public int MyAtoi(string str)
        {
            int result = 0;
            int sign = 1;

            if (!string.IsNullOrEmpty(str) && str.Length > 0)
            {
                double num = 0;

                for (int i = 0; i < str.Length; i++)
                {
                    // whitespace
                    if (str[i] == ' ')
                    {
                        // prev char is digit & current char is whitespace
                        // so exit loop
                        if (i > 0 && str[i - 1] >= '0' && str[i - 1] <= '9')
                        {
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    } // plus or minus char
                    else if (str[i] == '-' || str[i] == '+')
                    {
                        // continue loop if, current char is plus or minus sign
                        // and next char is digit
                        // but prev char is not a digit
                        // For example: "0-1" should yield 0, since sign
                        // after digit doesn't count as a valid char to continue conversion
                        if (i + 1 < str.Length && IsDigit(str[i + 1]) &&
                            !(i - 1 >= 0 && IsDigit(str[i - 1])))
                        {
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    } // current char is a digit
                    else if (IsDigit(str[i]))
                    {
                        // add sign
                        if (num == 0 && i >= 1 && str[i - 1] == '-')
                        {
                            sign = -1;
                        }

                        num = num * 10 + str[i] - '0';
                    }
                    else
                    {
                        break;
                    }
                }

                if (sign > 0 && num > Int32.MaxValue)
                {
                    result = Int32.MaxValue;
                }
                else if (sign < 0 && num < Int32.MinValue)
                {
                    result = Int32.MinValue;
                }
                else
                {
                    num = sign * num;
                    result = (int)num;
                }
            }

            return result;
        }

        public bool IsDigit(int val)
        {
            bool isDigit = false;

            if (val >= '0' && val <= '9')
            {
                isDigit = true;
            }

            return isDigit;
        }
    }
}
