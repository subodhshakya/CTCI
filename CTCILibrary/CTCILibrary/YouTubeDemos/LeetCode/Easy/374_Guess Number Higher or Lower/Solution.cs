using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._374_Guess_Number_Higher_or_Lower
{
    /** 
     * Forward declaration of guess API.
     * @param  num   your guess
     * @return 	     -1 if num is lower than the guess number
     *			      1 if num is higher than the guess number
     *               otherwise return 0
     * int guess(int num);
     */
    class Solution
    {
        public int GuessNumber(int n)
        {
            int low = 1;
            int high = n;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                int res = guess(mid);
                if (res == 0)
                    return mid;
                else if (res < 0)
                    high = mid - 1;
                else
                    low = mid + 1;
            }
            return -1;
        }

        // This functions is provided by parent class/API.
        public int guess(int m)
        {
            return 0;
        }
    }
}
