using System;
using System.Collections.Generic;
using System.Text;
using CTCILibrary.YouTubeDemos.LeetCode.Common;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._111_Minimum_Depth_Binary_Tree
{
    public static class Solution
    {
        /// <summary>
        /// Solution below uses BFS
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int MinDepth(TreeNode root)
        {
            if (root == null)
                return 0;

            LinkedList<TreeNode> nodeList = new LinkedList<TreeNode>();
            LinkedList<int> countList = new LinkedList<int>();

            nodeList.AddLast(root);
            countList.AddLast(1);

            while (nodeList.Count > 0)
            {
                TreeNode current = nodeList.First.Value;
                nodeList.RemoveFirst();
                int count = countList.First.Value;
                countList.RemoveFirst();

                if (current.left == null && current.right == null)
                {
                    return count;
                }

                if (current.left != null)
                {
                    nodeList.AddLast(current.left);
                    countList.AddLast(count + 1);
                }

                if (current.right != null)
                {
                    nodeList.AddLast(current.right);
                    countList.AddLast(count + 1);
                }
            }

            return 0;
        }
    }
}
