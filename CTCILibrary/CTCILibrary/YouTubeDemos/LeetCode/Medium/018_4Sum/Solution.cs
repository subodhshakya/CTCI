using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Medium._018_4Sum
{
    class Solution
    {
        /*
        The two pointers pattern requires the array to be sorted, so we do that first. Also, it's easier to deal with duplicates if the array is sorted: repeated values are next to each other and easy to skip.

        For 3Sum, we enumerate each value in a single loop, and use the two pointers pattern for the rest of the array. For kSum, we will have k - 2 nested loops to enumerate all combinations of k - 2 values.

        Algorithm

        We can implement k - 2 loops using a recursion. We will pass the starting point and k as the parameters. When k == 2, we will call twoSum, terminating the recursion.

        1. For the main function:

        - Sort the input array nums.
        - Call kSum with start = 0, k = 4, and target, and return the result.

        2. For kSum function:

        - Check if the sum of k smallest values is greater than target, or the sum of k largest values is smaller than target. Since the array is sorted, the smallest value is nums[start], and largest - the last element in nums.
        If so, no need to continue - there are no k elements that sum to target.
        - If k equals 2, call twoSum and return the result.
        - Iterate i through the array from start:
        --If the current value is the same as the one before, skip it.
        --Recursively call kSum with start = i + 1, k = k - 1, and target - nums[i].
        --For each returned set of values:
        ---Include the current value nums[i] into set.
        ---Add set to the result res.
        -Return the result res.

        3. For twoSum function:

        - Set the low pointer lo to start, and high pointer hi to the last index.
        - While low pointer is smaller than high:
        --If the sum of nums[lo] and nums[hi] is less than target, increment lo.
        ---Also increment lo if the value is the same as for lo - 1.
        --If the sum is greater than target, decrement hi.
        ---Also decrement hi if the value is the same as for hi + 1.
        --Otherwise, we found a pair:
        ---Add it to the result res.
        ---Decrement hi and increment lo.
        - Return the result res.
    
    */
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            Array.Sort(nums);
            return kSum(nums, target, 0, 4);
        }

        private IList<IList<int>> kSum(int[] nums, int target, int start, int k)
        {
            List<IList<int>> res = new List<IList<int>>();
            if (start == nums.Length || nums[start] * k > target || target > nums[nums.Length - 1] * k)
                return res;
            if (k == 2)
                return TwoSum(nums, target, start);
            for (int i = start; i < nums.Length; ++i)
                if (i == start || nums[i - 1] != nums[i])
                    foreach (var set in kSum(nums, target - nums[i], i + 1, k - 1))
                    {
                        List<int> list = new List<int>() { nums[i] };
                        list.AddRange(set);
                        res.Add(list);
                    }
            return res;
        }
        private List<IList<int>> TwoSum(int[] nums, int target, int start)
        {
            List<IList<int>> res = new List<IList<int>>();
            HashSet<int> s = new HashSet<int>();
            for (int i = start; i < nums.Length; ++i)
            {
                if (res.Count == 0 || res[res.Count - 1][1] != nums[i])
                    if (s.Contains(target - nums[i]))
                        res.Add(new List<int>() { target - nums[i], nums[i] });
                s.Add(nums[i]);
            }
            return res;
        }
    }
}
