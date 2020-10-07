using System;
using System.Collections.Generic;
using System.Text;
using CTCILibrary.YouTubeDemos.LeetCode.Common;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._257_Binary_Tree_Paths
{
    public class Solution
    {
        public IList<string> AllPaths { get; set; }
        public IList<string> BinaryTreePaths(TreeNode root)
        {
            AllPaths = new List<string>();
            BinaryTreePathsHelper(root, string.Empty);
            return AllPaths;
        }

        private void BinaryTreePathsHelper(TreeNode n, string currentPath)
        {
            if (n == null)
            {
                return;
            }            

            if (n.left == null && n.right == null)
            {
                currentPath += n.val.ToString();
                AllPaths.Add(currentPath);
                currentPath = string.Empty;
            }
            else
            {
                currentPath += n.val.ToString() + "->";
            }

            BinaryTreePathsHelper(n.left, currentPath);
            BinaryTreePathsHelper(n.right, currentPath);
        }
    }
}
