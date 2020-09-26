using System;
using System.Collections.Generic;
using System.Text;
using CTCILibrary.YouTubeDemos.LeetCode.Common;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._108_Converted_Sorted_Array_To_BST
{
    public class Solution
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            return SortedArrayToBSTHelper(nums, 0, nums.Length - 1);
        }

        public TreeNode SortedArrayToBSTHelper(int[] nums, int start, int end)
        {
            if (end < start)
                return null;

            int m = (start + end) / 2;
            TreeNode n = new TreeNode();
            n.val = nums[m];
            n.left = SortedArrayToBSTHelper(nums, start, m - 1);
            n.right = SortedArrayToBSTHelper(nums, m + 1, end);
            return n;
        }
    }
}
