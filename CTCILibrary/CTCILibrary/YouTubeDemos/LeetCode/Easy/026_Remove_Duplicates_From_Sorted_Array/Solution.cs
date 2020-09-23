using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._026_Remove_Duplicates_From_Sorted_Array
{
    class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
                return 0;
            int currentUniqueIndex = 0;
            for (int i = 0; i < (nums.Length - 1); i++)
            {
                if (nums[i] != nums[i + 1])
                {
                    currentUniqueIndex++;
                    nums[currentUniqueIndex] = nums[i + 1];
                }
            }
            return currentUniqueIndex + 1;
        }
    }
}
