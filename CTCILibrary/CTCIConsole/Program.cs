using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTCILibrary;
using CTCILibrary.YouTubeDemos.LeetCode.Common;

namespace CTCIConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(5);
            root.left = new TreeNode(1);
            root.right = new TreeNode(3);
            root.left.left = new TreeNode(7);
            root.left.right = new TreeNode(15);

            root.right.left = new TreeNode(9);
            root.right.right = new TreeNode(11);
            root.right.right.right = new TreeNode(17);

            CTCILibrary.YouTubeDemos.LeetCode.Easy._112_Path_Sum.Solution.HasPathSum(root, 17);
        }
    }
}
