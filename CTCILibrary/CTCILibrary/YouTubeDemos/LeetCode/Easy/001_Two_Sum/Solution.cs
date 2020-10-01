using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._001_Two_Sum
{
    /*
     * Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

        You may assume that each input would have exactly one solution, and you may not use the same element twice.

        You can return the answer in any order.
     * 
     */
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            //Brute force
            for (int i = 0; i < nums.Length; i++)
            {
                int num1 = nums[i];
                for (int j = i + 1; j < nums.Length; j++)
                {
                    int num2 = target - num1;
                    if (num2 == nums[j])
                    {
                        return new int[] { i, j };
                    }
                }
            }

            throw new Exception("No match found!");
        }
    }
}
