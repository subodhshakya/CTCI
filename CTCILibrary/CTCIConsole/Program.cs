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
            TreeNode t = new TreeNode(1)
            {
                left = new TreeNode(2)
                {
                    right = new TreeNode(5)
                },
                right = new TreeNode(3)
            };
            CTCILibrary.YouTubeDemos.LeetCode.Easy._257_Binary_Tree_Paths.Solution sln = new CTCILibrary.YouTubeDemos.LeetCode.Easy._257_Binary_Tree_Paths.Solution();
            var paths = sln.BinaryTreePaths(t);
        }
    }
}
