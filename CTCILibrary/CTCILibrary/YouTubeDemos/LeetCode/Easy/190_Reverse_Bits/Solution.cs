using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._190_Reverse_Bits
{
    class Solution
    {
        /// <summary>
        /// Using left and right shift
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public uint reverseBits(uint n)
        {
            uint ret = 0;
            int power = 31;
            while (n != 0)
            {
                ret += (n & 1) << power; // n & 1 will extract right most bit. E.g. 101101 & 000001 = 1. 
                //Then shift by 31 times to put it to leftmost as we are reverseing.
                n = n >> 1;
                power -= 1;
            }
            return ret;
        }
    }
}
