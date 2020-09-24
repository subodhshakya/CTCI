using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._053_Maximum_Subarray
{
    public static class MaxSubArraySolution
    {
        public static int MaxSubArray(int[] nums)
        {
            return MaxSubArrayHelper(nums, 0, nums.Length - 1);
        }

        static int MaxSubArrayHelper(int[] A, int L, int R)
        {
            if (L > R) return int.MinValue;

            int M = (L + R) / 2;
            int leftAns = MaxSubArrayHelper(A, L, M - 1);
            int rightAns = MaxSubArrayHelper(A, M + 1, R);
            int lMaxSum = 0;
            int sum = 0;
            for (int i = M - 1; i >= L; i--)
            {
                sum += A[i];
                lMaxSum = Math.Max(sum, lMaxSum);
            }

            int rMaxSum = 0;
            sum = 0;
            for (int i = M + 1; i <= R; i++)
            {
                sum += A[i];
                rMaxSum = Math.Max(sum, rMaxSum);
            }

            return Math.Max(lMaxSum + A[M] + rMaxSum, Math.Max(leftAns, rightAns));
        }
    }
}