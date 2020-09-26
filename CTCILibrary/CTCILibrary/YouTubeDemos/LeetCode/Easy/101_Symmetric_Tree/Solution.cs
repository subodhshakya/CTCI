using System;
using System.Collections.Generic;
using System.Text;
using CTCILibrary.YouTubeDemos.LeetCode.Common;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._101_Symmetric_Tree
{
    public class Solution
    {
        public bool SymmetryCheck(TreeNode leftN, TreeNode rightN)
        {
            if (leftN == null && rightN == null)
            {
                return true;
            }
            if (leftN == null || rightN == null)
            {
                return false;
            }

            return (leftN.val == rightN.val) &&
                SymmetryCheck(leftN.left, rightN.right) &&
                SymmetryCheck(leftN.right, rightN.left);
        }
    }
}
