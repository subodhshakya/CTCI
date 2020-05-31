using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary._05BitManipulation._05_06Conversion
{
    public static class Conversion
    {
        public static int BitSwapRequired1(int a, int b)
        {
            int count = 0;
            for (int c = a ^ b; c != 0; c = c >> 1)
            {
                count += c & 1;
            }

            return count;
        }

        public static int BitSwapRequired2(int a, int b)
        {
            int count = 0;
            for (int c = a ^ b; c != 0; c = c & (c - 1)) //c & (c - 1) will clears the least significant bit in c.
            {
                count++;
            }

            return count;
        }
    }
}
