using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._217_Contains_Duplicate
{
    /*
     * 
     * Given an array of integers, find if the array contains any duplicates.

        Your function should return true if any value appears at least twice in the array, and it should return false if every element is distinct.

        Example 1:

        Input: [1,2,3,1]
        Output: true
        Example 2:

        Input: [1,2,3,4]
        Output: false
        Example 3:

        Input: [1,1,1,3,3,4,3,2,4,2]
        Output: true
     */
    public class Solution
    {
        public bool ContainsDuplicate(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return false;

            HashSet<int> uniqueNums = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (uniqueNums.Contains(nums[i]))
                    return true;
                else
                    uniqueNums.Add(nums[i]);
            }

            return false;
        }
    }
}
