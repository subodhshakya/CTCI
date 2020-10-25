using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._326_Power_of_Three
{
    class Solution
    {
        public bool IsPowerOfThree(int n)
        {
            return (Math.Log10(n) / Math.Log10(3)) % 1 == 0;
        }
    }
}
