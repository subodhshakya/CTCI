using System;
using System.Collections.Generic;
using System.Text;
using CTCILibrary.YouTubeDemos.LeetCode.Common;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._110_Balanced_Binary_Tree
{
    public class Solution
    {
        public bool balanced { get; set; } = true;
        public bool IsBalanced(TreeNode root)
        {
            if (root == null)
                return true;
            HeightCheck(root);
            return balanced;
        }

        public int HeightCheck(TreeNode n)
        {
            if (n == null)
            {
                return -1;
            }

            int lHeight = HeightCheck(n.left);
            int rHeight = HeightCheck(n.right);
            if (Math.Abs(lHeight - rHeight) > 1)
            {
                balanced = false;
            }
            return Math.Max(lHeight, rHeight) + 1;
        }
    }
}
