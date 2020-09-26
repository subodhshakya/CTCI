using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._069_Sqrt_x
{
    public static class Solution
    {
        public static int MySqrt(int x)
        {
            // Base cases 
            if (x == 0 || x == 1)
                return x;

            // Staring from 1, try all 
            // numbers until i*i is  
            // greater than or equal to x. 
            long i = 1, result = 1;

            while (result <= x)
            {
                i++;
                result = i * i;
            }
            return (int)(i - 1);
        }

        /// <summary>
        /// Binary search approach
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int MySqrtBetter(int x)
        {
            if (x == 0 || x == 1)
            {
                return x;
            }

            long start = 1;
            long end = x;
            long ans = 0;

            while (start <= end)
            {
                long mid = (start + end) / 2;
                Console.WriteLine("Mid: " + mid);

                if (mid * mid == x)
                {
                    return (int)mid;
                }

                if ((mid * mid) < x)
                {
                    start = mid + 1;
                    ans = mid;
                }
                else
                {
                    end = mid - 1;
                }
            }

            return (int)ans;
        }
    }
}
