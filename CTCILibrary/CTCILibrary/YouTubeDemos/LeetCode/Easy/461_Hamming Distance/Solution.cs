using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._461_Hamming_Distance
{
    class Solution
    {
        public int HammingDistance(int x, int y)
        {
            int xorResult = x ^ y;

            int count = 0;
            while (xorResult > 0)
            {
                int lsb = xorResult & 1; // Extract LSB (Least Significant Bit)
                count += lsb;
                xorResult = xorResult >> 1; // Shift right
            }

            return count;
        }
    }
}
