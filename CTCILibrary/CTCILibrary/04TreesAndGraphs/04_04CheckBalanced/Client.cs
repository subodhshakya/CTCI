using CTCILibrary._04TreesAndGraphs._04_02MinimalTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary._04TreesAndGraphs._04_04CheckBalanced
{
    public class Client
    {
        public void Run()
        {
            // Copying run setup code from previous problem to create tree
            int[] sortedArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            MinimalTree minimalTree = new MinimalTree();
            TreeNode rootNode = minimalTree.CreateMinimalBST(sortedArray);

            CheckBalanced checkBalanced = new CheckBalanced();
            Console.WriteLine("Is Balanced: " + checkBalanced.IsBalanced(rootNode));

            CheckBalancedV2 checkBalancedV2 = new CheckBalancedV2();
            Console.WriteLine("Is Balanced: " + checkBalancedV2.IsBalanced(rootNode));
        }
    }
}
