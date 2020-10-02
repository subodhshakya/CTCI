using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._191_Number_Of_1_Bits
{
    class Solution
    {
        public int HammingWeight(uint n)
        {
            int count = 0;
            while (n != 0)
            {
                if ((n & 1) == 1) // Main comparison is here. Extract rightmost bit and compare.
                    count++;
                n = n >> 1;
            }

            return count;
        }
    }
}
