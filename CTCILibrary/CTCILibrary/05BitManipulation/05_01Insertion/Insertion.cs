using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary._05BitManipulation._05_01Insertion
{
    public static class Insertion
    {
        /* Insertion: You are given two 32-bit numbers, N and M, and two bit positions, i and j.
         * Write a method to insert M into N such that M starts at bit j and ends at bit i.
         * You can assume that the bits j through i have enough space to fit all of M. That is,
         * if M = 10011, you can assume that there are at least 5 bits between j and i. You would
         * not, for example, have j = 3 and i = 2, becaue M could not fully fit between bit 3 and bit 2.
         * 
         * Example
         * Input: N = 10000000000, M = 10011, i = 2, j = 6 // Starts at j and ends at i. 
         * If number of bits in M is shorter than gap between i and j then will leave N's bit as it is for remaining stops upto i.
         * Output: N = 10001001100
         */

        public static int UpdateBits(int n, int m, int i, int j)
        {
            //N = 10101011110 // Assume 0 preceeds as this is 32 bit
            //M = 10011

            // Step 1: Clear bits i = 2 to j = 6 in N so that we can insert M

            #region Step 1
            int allOnes = ~0; // Tilde operator flips the bits of its operand. So mask has all ones.            
            int left = allOnes << (j + 1);
            int right = ((1 << i) - 1); // Subtract as we want to get all 1s e.g. i = 2, 1 << 2 have output 100 and -1 will make it 11.
            int mask = left | right; // Single | (pipe) is bitwise 'OR'

            int n_cleared = (n & mask); // Clear bits j through i
            #endregion

            #region Step 2
            int m_shifted = (m << i); // Move m to correct position
            return n_cleared | m_shifted; // OR them and we are done.
            #endregion
        }
    }
}
