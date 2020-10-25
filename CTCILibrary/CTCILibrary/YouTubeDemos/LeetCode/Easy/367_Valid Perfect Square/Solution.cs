using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._367_Valid_Perfect_Square
{
    class Solution
    {
        public bool IsPerfectSquare(int num)
        {
            return (Math.Sqrt(num) % 1) == 0;
        }
    }
}
