using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Medium._015_3Sum
{
    /*  Given an array nums of n integers, are there elements a, b, c in nums such that a + b + c = 0? Find all unique triplets in the array which gives the sum of zero.

        Notice that the solution set must not contain duplicate triplets.
 
        Example 1:

        Input: nums = [-1,0,1,2,-1,-4]
        Output: [[-1,-1,2],[-1,0,1]]
        Example 2:

        Input: nums = []
        Output: []
        Example 3:

        Input: nums = [0]
        Output: []
 

        Constraints:

        0 <= nums.length <= 3000
        -10^5 <= nums[i] <= 10^5
     * 
     */
    class Solution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            List<IList<int>> result = new List<IList<int>>();
            HashSet<string> tripletSet = new HashSet<string>();
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                int j = i + 1;
                int k = nums.Length - 1;

                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }

                while (j < k)
                {
                    if (k < nums.Length - 1 && nums[k] == nums[k + 1])
                    {
                        k--;
                        continue;
                    }

                    if ((nums[i] + nums[j] + nums[k]) == 0)
                    {
                        string tripletKey = nums[i] + ":" + nums[j] + ":" + nums[k];
                        if (!tripletSet.Contains(tripletKey))
                        {
                            List<int> currentNums = new List<int>() { nums[i], nums[j], nums[k] };
                            result.Add(currentNums);
                            tripletSet.Add(tripletKey);
                        }
                        j++;
                        k--;
                    }
                    else if ((nums[i] + nums[j] + nums[k]) < 0)
                        j++;
                    else
                        k--;
                }
            }

            return result;
        }
    }
}
