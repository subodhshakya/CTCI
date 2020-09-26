using System;
using System.Collections.Generic;
using System.Text;
using CTCILibrary.YouTubeDemos.LeetCode.Common;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._104_Maximum_Depth_Of_Binary_Tree
{
    public class Solution
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            int ldepth = MaxDepth(root.left);
            int rdepth = MaxDepth(root.right);

            if (ldepth > rdepth)
            {
                return ldepth + 1;
            }
            else
            {
                return rdepth + 1;
            }                
        }
    }
}
