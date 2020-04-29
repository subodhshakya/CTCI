using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary._04TreesAndGraphs._04_02MinimalTree
{
    public class MinimalTree
    {
        /* Minimal Tree: Given a sorted (increasing order) array with unique integer elements,
         * write an algorithm to create a binary search tree with minimal height.         
         */
        public TreeNode CreateMinimalBST(int[] sortedArray)
        {
            return CreateMinimalBST(sortedArray, 0, sortedArray.Length - 1);
        }

        public TreeNode CreateMinimalBST(int[] sortedArray, int start, int end)
        {
            if (end < start)
            {
                return null;
            }

            int mid = (start + end) / 2;
            TreeNode n = new TreeNode(sortedArray[mid]);
            n.Left = CreateMinimalBST(sortedArray, start, mid - 1);
            n.Right = CreateMinimalBST(sortedArray, mid + 1, end);
            return n;
        }
    }
}
