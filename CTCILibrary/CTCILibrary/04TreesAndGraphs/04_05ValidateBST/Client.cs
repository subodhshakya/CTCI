using CTCILibrary._04TreesAndGraphs._04_02MinimalTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary._04TreesAndGraphs._04_05ValidateBST
{
    public class Client
    {
        public void Run()
        {
            // Tree setup
            // Copying run setup code from previous problem to create tree
            int[] sortedArray = new int[] { 1, 2, 4, 3, 5, 6, 7, 8 };
            MinimalTree minimalTree = new MinimalTree();
            TreeNode rootNode = minimalTree.CreateMinimalBST(sortedArray);

            ValidateBST validateBST = new ValidateBST();
            bool isBST = validateBST.CheckBSTApproach1(rootNode, sortedArray.Length);
            Console.WriteLine("Is BST:" + isBST);
        }
    }
}
