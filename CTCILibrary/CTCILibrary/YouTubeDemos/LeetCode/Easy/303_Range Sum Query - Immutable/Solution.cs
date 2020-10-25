using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._303_Range_Sum_Query___Immutable
{
    class Solution
    {
    }

    public class NumArray
    {
        public int[] Nums { get; set; }

        public NumArray(int[] nums)
        {
            Nums = nums;
        }

        public int SumRange(int i, int j)
        {
            int sumRange = 0;
            for (int k = i; k <= j; k++)
            {
                sumRange += Nums[k];
            }

            return sumRange;
        }
    }

    /**
     * Your NumArray object will be instantiated and called as such:
     * NumArray obj = new NumArray(nums);
     * int param_1 = obj.SumRange(i,j);
     */
}
