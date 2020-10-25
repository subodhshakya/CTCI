using System;
using System.Collections.Generic;
using System.Text;
using CTCILibrary.YouTubeDemos.LeetCode.Common;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._404_Sum_of_Left_Leaves
{
    class Solution
    {
        public int Sum { get; set; } = 0;
        public int SumOfLeftLeaves(TreeNode root)
        {
            SumHelper(root);
            return Sum;
        }

        private void SumHelper(TreeNode tn)
        {
            if (tn == null)
                return;


            if (IsLeafNode(tn.left))
                Sum += tn.left.val;

            SumHelper(tn.left);
            SumHelper(tn.right);
        }

        private bool IsLeafNode(TreeNode tn)
        {
            if (tn != null)
                return tn.left == null && tn.right == null;

            return false;
        }
    }
}
