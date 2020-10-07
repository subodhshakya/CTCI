using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._219_Contains_Duplicate_II
{
    /*
     * Given an array of integers and an integer k, find out whether there are two distinct indices i and j in the array such that nums[i] = nums[j] and the absolute difference between i and j is at most k.

        Example 1:

        Input: nums = [1,2,3,1], k = 3
        Output: true
        Example 2:

        Input: nums = [1,0,1,1], k = 1
        Output: true
        Example 3:

        Input: nums = [1,2,3,1,2,3], k = 2
        Output: false
     */
    public class Solution
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            if (nums == null || nums.Length == 0)
            {
                return false;
            }
            Dictionary<int, int> numsToIndexMap = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (numsToIndexMap.ContainsKey(nums[i]) &&
                   numsToIndexMap[nums[i]] != i &&
                  Math.Abs(numsToIndexMap[nums[i]] - i) <= k)
                {
                    return true;
                }
                numsToIndexMap[nums[i]] = i;
            }

            return false;
        }
    }
}
