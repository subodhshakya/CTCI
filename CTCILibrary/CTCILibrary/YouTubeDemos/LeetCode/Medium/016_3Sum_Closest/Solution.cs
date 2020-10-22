using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Medium._016_3Sum_Closest
{
    public class Solution
    {
        /*
    The two pointers pattern requires the array to be sorted, so we do that first. As our BCR is  O(n^2), the sort operation would not change the overall time complexity.
    
    Time complexity: O(n^2)
    Space: O(log n) to O(n) depending on the implementation of sort algo.
    */
        public int ThreeSumClosestTwoPointerApproach(int[] nums, int target)
        {
            Array.Sort(nums);
            int minDifference = int.MaxValue;
            int closest = nums[0] + nums[1] + nums[2];
            for (int i = 0; i < nums.Length; i++)
            {
                int j = i + 1;
                int k = nums.Length - 1;

                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }

                if (target == closest)
                    break;

                while (j < k)
                {
                    if (k < nums.Length - 1 && nums[k] == nums[k + 1])
                    {
                        k--;
                        continue;
                    }
                    int sum = nums[i] + nums[j] + nums[k];
                    int currentDiff = Math.Abs(sum - target);
                    if (currentDiff < minDifference)
                    {
                        minDifference = currentDiff;
                        closest = sum;
                    }
                    else if (currentDiff == 0)
                    {
                        closest = target;
                        break;
                    }
                    if (sum < target)
                        j++;
                    else
                        k--;
                }
            }

            return closest;
        }
        // Note: There is also binary search approach which is O(n^2 log n) in Time. So use two pointer soln as coded above.
    }
}
