using CTCILibrary._04TreesAndGraphs._04_11RandomNode;
using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary._04TreesAndGraphs._04_12PathsWithSum
{
    public class Client
    {
        public void Run()
        {
            TreeNode root = new TreeNode(10);

            TreeNode n05 = new TreeNode(5);            
            TreeNode n_03 = new TreeNode(-3);

            root.Left = n05;
            root.Right  = n_03;

            TreeNode n03 = new TreeNode(3);
            TreeNode n01 = new TreeNode(1);
            TreeNode n02 = new TreeNode(2);
            n01.Right = n02;

            n05.Left = n03;
            n05.Right = n01;

            TreeNode n03_2 = new TreeNode(3);
            TreeNode n_02 = new TreeNode(-2);

            n03.Left = n03_2;
            n03.Right = n_02;
            
            TreeNode n11 = new TreeNode(11);
            n_03.Right = n11;
            
            PathsWithSum pathWithSum = new PathsWithSum();
            int totalCount = pathWithSum.CountPathsWithSum(root, 18);
        }
    }
}
