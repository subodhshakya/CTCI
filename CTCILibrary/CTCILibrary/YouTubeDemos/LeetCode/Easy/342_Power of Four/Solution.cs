using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._342_Power_of_Four
{
    class Solution
    {
        public bool IsPowerOfFour(int num)
        {
            return (Math.Log10(num) / Math.Log10(4)) % 1 == 0;
        }
    }
}
