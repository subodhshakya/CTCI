using CTCILibrary._04TreesAndGraphs._04_02MinimalTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary._04TreesAndGraphs._04_04CheckBalanced
{
    public class CheckBalanced
    {
        /* Check Balanced: Implement a function to check if a binary tree is balanced.
         * For the purposes of this question, a balanced tree is defined to be a tree
         * such that the heights of the two subtrees of any node never differ by more
         * than one.         
         */

        public bool IsBalanced(TreeNode root)
        {
            if (root == null) return true; // Base case

            int heightDiff = GetHeight(root.Left) - GetHeight(root.Right);
            if (Math.Abs(heightDiff) > 1)
            {
                return false;
            }
            else
            { // Recurse
                return IsBalanced(root.Left) && IsBalanced(root.Right);
            }
        }

        public int GetHeight(TreeNode root)
        {
            if (root == null) return -1; // Base case

            return Math.Max(GetHeight(root.Left), GetHeight(root.Right)) + 1;
        }
    }
}
