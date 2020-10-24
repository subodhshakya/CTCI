using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Medium._034_Find_First_and_Last_Position_of_Element_in_Sorted_Array
{
    /*
     * Given an array of integers nums sorted in ascending order, find the starting and ending position of a given target value.

        If target is not found in the array, return [-1, -1].

        Follow up: Could you write an algorithm with O(log n) runtime complexity?

 

        Example 1:

        Input: nums = [5,7,7,8,8,10], target = 8
        Output: [3,4]

        Example 2:

        Input: nums = [5,7,7,8,8,10], target = 6
        Output: [-1,-1]
        
        Example 3:

        Input: nums = [], target = 0
        Output: [-1,-1]
     * 
     */
    public class Solution
    {
        public int[] SearchRange(int[] nums, int target)
        {
            return SearchRecursive(nums, target);
        }

        // My version
        private int[] SearchLinear(int[] nums, int target)
        {
            int a = -1;
            int b = -1;
            int targetIndex = -1;
            if (nums.Length == 0)
                return new int[] { a, b };

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    targetIndex = i;
                    if ((i + 1) < nums.Length)
                    {
                        if (nums[i] == nums[i + 1] && a == -1)
                        {
                            a = i;
                        }
                        // check if there is break in repeation
                        else if (nums[i] != nums[i + 1] && a != -1)
                        {
                            b = i;
                        }
                    }
                    // for the case when there is repeated target but reached end of array
                    else if (a != -1 && b == -1 && (i - 1) >= 0 && nums[i - 1] == target)
                    {
                        b = i;
                    }
                }
            }

            if (targetIndex != -1 && a == -1 && b == -1)
            {
                a = b = targetIndex;
            }

            return new int[] { a, b };
        }

        // Geeksforgeeks version! really amazing as it is short
        private int[] SearchLinear2(int[] nums, int target)
        {
            int n = nums.Length;
            int first = -1, last = -1;

            for (int i = 0; i < n; i++)
            {
                if (target != nums[i])
                    continue;
                if (first == -1)
                    first = i;
                last = i;
            }

            return new int[] { first, last };
        }

        public int[] SearchRecursive(int[] nums, int target)
        {
            int a = SearchFirst(nums, 0, nums.Length - 1, target);
            int b = SearchLast(nums, 0, nums.Length - 1, target);
            return new int[] { a, b };
        }

        private int SearchFirst(int[] nums, int left, int right,int target)
        {
            if (left > right)
            {
                return -1;
            }

            int m = left + ((right - left) / 2);

            if ((m == 0 || nums[m - 1] != target) && nums[m] == target)
            {
                return m;
            }
            else if (target > nums[m])
            {
                return SearchFirst(nums, m + 1, right, target);
            }
            else
                return SearchFirst(nums, left, m - 1, target);
        }

        private int SearchLast(int[] nums, int left, int right, int target)
        {
            if (left > right)
            {
                return -1;
            }

            int m = left + ((right - left) / 2);

            if ((m == nums.Length - 1 || nums[m + 1] != target) && nums[m] == target)
            {
                return m;
            }
            else if (target < nums[m])
            {
                return SearchLast(nums, left, m - 1, target); 
            }
            else
                return SearchLast(nums, m + 1, right, target);
        }
    }
}
