using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._038_Count_And_Say
{
    /*
     * The count-and-say sequence is the sequence of integers with the first five terms as following:
        1.     1
        2.     11
        3.     21
        4.     1211
        5.     111221
        1 is read off as "one 1" or 11.
        11 is read off as "two 1s" or 21.
        21 is read off as "one 2, then one 1" or 1211.

        Given an integer n where 1 ≤ n ≤ 30, generate the nth term of the count-and-say sequence. You can do so recursively, in other words from the previous member read off the digits, counting the number of digits in groups of the same digit.

        Note: Each term of the sequence of integers will be represented as a string.
     * 
     */
    class Solution
    {
        static string CountAndSay(int n)
        {
            return GetNthCountAndSay(n, 1, "1");
        }
        static string GetNthCountAndSay(int n, int itr, string seq)
        {
            string count = seq;
            if (n == itr)
            {
                return count;
            }
            return GetNthCountAndSay(n, itr + 1, GetCount(seq));
        }

        static string GetCount(string numStr)
        {
            int seqCount = 1;
            string countSeq = string.Empty;
            int i = 0;
            for (i = 0; i < (numStr.Length - 1); i++)
            {
                if (numStr[i] == numStr[i + 1])
                {
                    seqCount++;
                }
                else
                {
                    countSeq += seqCount.ToString() + numStr[i];
                    seqCount = 1;
                }
            }
            if (i == (numStr.Length - 1))
            {
                countSeq += seqCount.ToString() + numStr[i];
            }
            return countSeq;
        }
    }
}
