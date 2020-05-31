using CTCILibrary._04TreesAndGraphs.Fundamentals._02_Depth_First_Search;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace CTCILibrary._05BitManipulation._05_03FlipBitToWin
{
    public static class FlipBitToWin
    {
        /* Flip Bit to Win: You have an integer and you can flip exactly
         * one bit from a 0 to a 1. Write code to find the length of the
         * longest sequence of 1s you could create.
         * 
         * Example:
         * Input:       1775    (or: 11011101111)
         * Output:      8
         */

        const int INTEGER_BYTESIZE = 4; // Integer is 32 bits which is 4 bytes.

        public static int LongestSequence(int n)
        {
            if (n == -1) return INTEGER_BYTESIZE * 8;

            List<int> sequences = GetAlternatingSequence(n);

            return FindLongestSequence(sequences);
        }

        public static List<int> GetAlternatingSequence(int n)
        {
            List<int> sequences = new List<int>();
            int searchingFor = 0;
            int counter = 0;

            for (int i = 0; i < INTEGER_BYTESIZE * 8; i++)
            {
                Console.WriteLine(Convert.ToString(n, 2));
                if ((n & 1) != searchingFor)
                {
                    sequences.Add(counter);
                    searchingFor = n & 1; // Flip 1 to 0 or 0 to 1
                    counter = 0;
                }
                counter++;
                Console.WriteLine(Convert.ToString(n, 2));
                n = n >> 1;
                Console.WriteLine(Convert.ToString(n, 2));
            }
            sequences.Add(counter);

            return sequences;
        }

        public static int FindLongestSequence(List<int> seq)
        {
            int maxSeq = 1;

            for (int i = 0; i < seq.Count; i += 2)
            {
                int zerosSeq = seq[i];
                int onesSeqRight = i - 1 >= 0 ? seq[i - 1] : 0;
                int onesSeqLeft = i + 1 < seq.Count ? seq[i + 1] : 0;

                int thisSeq = 0;
                if (zerosSeq == 1) // Can merge
                {
                    thisSeq = onesSeqLeft + 1 + onesSeqRight;
                }
                else if (zerosSeq > 1) // Just add a zero to either side
                {
                    thisSeq = 1 + Math.Max(onesSeqLeft, onesSeqRight);
                }
                else if (zerosSeq == 0) // No zeros but take either side
                {
                    thisSeq = Math.Max(onesSeqLeft, onesSeqRight);
                }

                maxSeq = Math.Max(thisSeq, maxSeq);
            }

            return maxSeq;
        }
    }
}