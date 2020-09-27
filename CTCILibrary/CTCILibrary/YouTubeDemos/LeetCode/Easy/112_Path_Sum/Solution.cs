using System;
using System.Collections.Generic;
using System.Text;
using CTCILibrary.YouTubeDemos.LeetCode.Common;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._112_Path_Sum
{

    /* Test data
        TreeNode root = new TreeNode(5);
        root.left = new TreeNode(1);
        root.right = new TreeNode(3);
        root.left.left = new TreeNode(7);
        root.left.right = new TreeNode(15);

        root.right.left = new TreeNode(9);
        root.right.right = new TreeNode(11);
        root.right.right.right = new TreeNode(17);     
     */
    public static class Solution
    {
        public static bool hasPathSum = false;
        public static bool HasPathSum(TreeNode root, int sum)
        {
            PathSumHelper(root, sum, 0);
            return hasPathSum;
        }

        public static void PathSumHelper(TreeNode n, int targetSum, int currentSum)
        {
            if (n == null || hasPathSum)
            {
                return;
            }
            currentSum += n.val;
            if (n.left == null && n.right == null)
            {
                if (currentSum == targetSum)
                {
                    hasPathSum = true;
                }
                return;
            }            
            
            PathSumHelper(n.left, targetSum, currentSum);
            PathSumHelper(n.right, targetSum, currentSum);            
        }
    }
}
