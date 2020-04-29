using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary._04TreesAndGraphs._04_02MinimalTree
{
    public class Client
    {
        public void Run()
        {
            int[] sortedArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            MinimalTree minimalTree = new MinimalTree();
            TreeNode rootNode = minimalTree.CreateMinimalBST(sortedArray);
        }
    }
}
