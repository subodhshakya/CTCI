using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._169_Majority_Number
{
    /*
     * 169. Majority Element
     * 
     * Given an array of size n, find the majority element. The majority element is the element that appears more than ⌊ n/2 ⌋ times.

        You may assume that the array is non-empty and the majority element always exist in the array.

        Example 1:

        Input: [3,2,3]
        Output: 3
        Example 2:

        Input: [2,2,1,1,1,2,2]
        Output: 2
     * 
     */
    public class Solution
    {
        public int MajorityElement(int[] nums)
        {
            Dictionary<int, int> numberToCountMap = new Dictionary<int, int>();
            int majorityNumber = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (numberToCountMap.ContainsKey(nums[i]))
                {
                    numberToCountMap[nums[i]] += 1;
                }
                else
                {
                    numberToCountMap.Add(nums[i], 1);
                }
                if (numberToCountMap[nums[i]] > (nums.Length / 2))
                {
                    majorityNumber = nums[i];
                    break;
                }
            }
            return majorityNumber;
        }
    }
}
