using System;
using System.Collections.Generic;
using System.Text;
using CTCILibrary.YouTubeDemos.LeetCode.Common;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._226_Invert_Binary_Tree
{
    /*
     * Invert a binary tree.

        Example:

        Input:

             4
           /   \
          2     7
         / \   / \
        1   3 6   9
        Output:

             4
           /   \
          7     2
         / \   / \
        9   6 3   1
        Trivia:
        This problem was inspired by this original tweet by Max Howell:

        Google: 90% of our engineers use the software you wrote (Homebrew), but you can’t invert a binary tree on a whiteboard so f*** off.
     * 
     */
    public class Solution
    {
        public TreeNode InvertTree(TreeNode root)
        {
            return InvertTreeRecursive(root);
        }

        public TreeNode InvertTreeIterative(TreeNode root)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();

            if (root != null)
                queue.Enqueue(root);

            while (queue.Count > 0)
            {
                TreeNode q = queue.Dequeue();

                if (q.left != null)
                    queue.Enqueue(q.left);
                if (q.right != null)
                    queue.Enqueue(q.right);

                TreeNode temp = q.left;
                q.left = q.right;
                q.right = temp;
            }

            return root;
        }

        public TreeNode InvertTreeRecursive(TreeNode root)
        {
            if (root == null)
                return root;

            InvertTreeRecursive(root.left);
            InvertTreeRecursive(root.right);

            TreeNode n = root.left;
            root.left = root.right; ;
            root.right = n;

            return root;
        }
    }
}
