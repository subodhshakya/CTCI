using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._035_Search_Insert_Position
{
    class Solution
    {
        public int SearchInsert(int[] nums, int target)
        {

            if (nums.Length == 0)
            {
                return 0;
            }

            int targetIndex = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    return i;
                }
                else if (nums[i] > target)
                {
                    if (targetIndex == -1)
                    {
                        targetIndex = i;
                    }
                }
            }
            if (targetIndex == -1)
                targetIndex = nums.Length;
            return targetIndex;
        }
    }
}
