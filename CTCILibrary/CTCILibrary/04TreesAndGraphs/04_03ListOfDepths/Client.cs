using CTCILibrary._04TreesAndGraphs._04_02MinimalTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary._04TreesAndGraphs._04_03ListOfDepths
{
    public class Client
    {
        public void Run()        
        {
            // Copying run setup code from previous problem to create tree
            int[] sortedArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            MinimalTree minimalTree = new MinimalTree();
            TreeNode rootNode = minimalTree.CreateMinimalBST(sortedArray);

            ListOfDepths lstOfDepths = new ListOfDepths();
            List<LinkedList<TreeNode>> listOfLinkedList = lstOfDepths.CreateLevelLinkedListNonRecursive(rootNode);

            List<LinkedList<TreeNode>> listOfLinkedListRecursive = lstOfDepths.CreateLevelLinkedListRecursive(rootNode);
        }
    }
}
