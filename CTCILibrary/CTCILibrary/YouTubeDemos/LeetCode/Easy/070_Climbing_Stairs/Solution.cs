using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._070_Climbing_Stairs
{
    public static class Solution
    {        
        public static int ClimbStairs(int n)
        {
            int[] memo = new int[n];
            //return ClimbStairs(0, n);
            return ClimbStairsWithMemo(0, n, memo);
        }

        public static int ClimbStairs(int i, int n)
        {
            if (i > n)
            {
                return 0;
            }
            if (i == n)
            {
                return 1;
            }
            return ClimbStairs(i + 1, n) + ClimbStairs(i + 2, n);
        }

        public static int ClimbStairsWithMemo(int i, int n, int[] memo)
        {
            if (i > n)
            {
                return 0;
            }
            if (i == n)
            {
                return 1;
            }
            if (memo[i] != 0)
            {
                return memo[i];
            }
            memo[i] = ClimbStairsWithMemo(i + 1, n, memo) + ClimbStairsWithMemo(i + 2, n, memo);
            return memo[i];
        }
    }
}
