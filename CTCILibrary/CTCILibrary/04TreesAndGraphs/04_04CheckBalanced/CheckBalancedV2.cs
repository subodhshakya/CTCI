using CTCILibrary._04TreesAndGraphs._04_02MinimalTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary._04TreesAndGraphs._04_04CheckBalanced
{
    public class CheckBalancedV2
    {
        public int CheckHeight(TreeNode root)
        {
            if (root == null) return -1;

            int leftHeight = CheckHeight(root.Left);
            if (leftHeight == int.MinValue) return int.MinValue; // Pass error up

            int rightHeight = CheckHeight(root.Right);
            if (rightHeight == int.MinValue) return int.MinValue; // Pass error up

            int heightDiff = leftHeight - rightHeight;
            if (Math.Abs(heightDiff) > 1)
            {
                return int.MinValue; // Found error -> pass up
            }
            else
            {
                return Math.Max(leftHeight, rightHeight) + 1;
            }
        }

        public bool IsBalanced(TreeNode root)
        {
            return CheckHeight(root) != int.MinValue;
        }
    }
}