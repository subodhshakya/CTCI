using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._453_Minimum_Moves_to_Equal_Array_Elements
{
    class Solution
    {
        public int MinMoves(int[] nums)
        {
            int sum = nums[0];
            int minValue = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                sum += nums[i];
                if (nums[i] < minValue)
                {
                    minValue = nums[i];
                }
            }
            return sum - (minValue * nums.Length);
        }
    }
}
