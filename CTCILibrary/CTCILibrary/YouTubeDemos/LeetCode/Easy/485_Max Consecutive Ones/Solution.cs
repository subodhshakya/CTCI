using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._485_Max_Consecutive_Ones
{
    class Solution
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int maxCount = 0;
            int previous = 0;
            int consCount = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (previous == 1 && nums[i] == 1)
                {
                    consCount++;
                }
                else if (nums[i] == 1)
                    consCount = 1;
                if (consCount > maxCount)
                    maxCount = consCount;

                previous = nums[i];
            }
            return maxCount;
        }
    }
}
