using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._027_Remove_Elements
{
    class Solution
    {
        public int RemoveElement(int[] nums, int val)
        {
            int currentIndex = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[currentIndex] = nums[i];
                    currentIndex++;
                }
            }
            return currentIndex;
        }
    }
}
