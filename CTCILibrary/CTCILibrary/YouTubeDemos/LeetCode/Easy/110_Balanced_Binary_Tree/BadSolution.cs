using System;
using System.Collections.Generic;
using System.Text;
using CTCILibrary.YouTubeDemos.LeetCode.Common;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._110_Balanced_Binary_Tree
{
    // This bad solution uses recursive GetHeight function at each node.
    // Another good solution finds height and calculates difference as it goes.
    public class BadSolution
    {
        public bool IsBalanced(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            int heightDiff = GetHeight(root.left) - GetHeight(root.right);
            if (Math.Abs(heightDiff) > 1)
            {
                return false;
            }
            else
                return IsBalanced(root.left) && IsBalanced(root.right);
        }

        public int GetHeight(TreeNode n)
        {
            if (n == null)
            {
                return -1;
            }

            return Math.Max(GetHeight(n.left), GetHeight(n.right)) + 1;
        }
    }
}
