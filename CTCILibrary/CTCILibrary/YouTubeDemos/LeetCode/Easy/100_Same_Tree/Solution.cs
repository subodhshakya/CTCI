using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._100_Same_Tree
{
    /*
     * Given two binary trees, write a function to check if they are the same or not.

        Two binary trees are considered the same if they are structurally identical and the nodes have the same value.

        Example 1:

        Input:     1         1
                  / \       / \
                 2   3     2   3

                [1,2,3],   [1,2,3]

        Output: true

        Example 2:

        Input:     1         1
                  /           \
                 2             2

                [1,2],     [1,null,2]

        Output: false
        Example 3:

        Input:     1         1
                  / \       / \
                 2   1     1   2

                [1,2,1],   [1,1,2]

        Output: false
     * 
     */
    public class TreeNode
    {
         public int val;
         public TreeNode left;
         public TreeNode right;
         public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
          {
              this.val = val;
              this.left = left;
              this.right = right;
        }
    }
    public static class Solution
    {
        public static bool IsSameTree(TreeNode p, TreeNode q)
        {
            StringBuilder sbP = new StringBuilder();
            StringBuilder sbQ = new StringBuilder();
            GetPreOrderString(p, sbP);
            GetPreOrderString(q, sbQ);
            return sbP.ToString() == sbQ.ToString();
        }

        public static void GetPreOrderString(TreeNode n, StringBuilder sb)
        {
            if (n == null)
            {
                sb.Append("X");
                return;
            }

            sb.Append(n.val + " ");
            GetPreOrderString(n.left, sb);
            GetPreOrderString(n.right, sb);
        }

        public static bool IsSameTreePreOrderRecursion(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
            {
                return true;
            }

            if (p == null || q == null)
            {
                return false;
            }

            if (p != null && q != null && q.val != p.val)
            {
                return false;
            }
            return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
        }
    }
}
