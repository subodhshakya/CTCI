using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._283_Move_Zeroes
{
    /*
     * Given an array nums, write a function to move all 0's to the end of it while maintaining the relative order of the non-zero elements.

Example:

Input: [0,1,0,3,12]
Output: [1,3,12,0,0]
Note:

You must do this in-place without making a copy of the array.
Minimize the total number of operations.
     * 
     */
    class Solution
    {
        public void MoveZeroes(int[] nums)
        {
            for (int lastNonZeroFoundAt = 0, cur = 0; cur < nums.Length; cur++)
            {
                if (nums[cur] != 0)
                {
                    Swap(ref nums[lastNonZeroFoundAt], ref nums[cur]);
                    lastNonZeroFoundAt++;
                }
            }
        }

        private void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
