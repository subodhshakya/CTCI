using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Medium._029_Divide_Two_Integers
{
    class Solution
    {
        public int Divide(int dividend, int divisor)
        {

            //handle special cases
            if (divisor == 0) return int.MaxValue;
            if (divisor == -1 && dividend == int.MinValue)
                return int.MaxValue;

            //get positive values
            long pDividend = Math.Abs((long)dividend);
            long pDivisor = Math.Abs((long)divisor);

            int result = 0;
            while (pDividend >= pDivisor)
            {
                //calculate number of left shifts
                int numShift = 0;
                /* Note
                 * x << k == x multiplied by 2 to the power of k
                 * x >> k == x divided by 2 to the power of k
                 */
                // The while loop is incrementing and testing if pDividend >= pDivisor * 2 pow numShift. So runtime is O(log n).
                while (pDividend >= (pDivisor << numShift))
                {
                    numShift++;
                }

                //dividend minus the largest shifted divisor
                result += 1 << (numShift - 1); // 1 * 2 pow (numShift - 1).
                pDividend -= (pDivisor << (numShift - 1));
            }

            if ((dividend > 0 && divisor > 0) || (dividend < 0 && divisor < 0))
            {
                return result;
            }
            else
            {
                return -result;
            }

        }
    }
}
