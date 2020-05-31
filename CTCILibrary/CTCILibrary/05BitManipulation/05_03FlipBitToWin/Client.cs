using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary._05BitManipulation._05_03FlipBitToWin
{
    public static class Client
    {
        public static void Run()        
        {
            int output = FlipBitToWin.LongestSequence(1775);

            // Some experiment on bitwise AND operator.
            int a = 0b11011101111;
            string binStr1 = Convert.ToString(a, 2);
            int c = a & 1;
            string binStr2 = Convert.ToString(c, 2);
        }
    }
}
