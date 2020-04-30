using CTCILibrary._04TreesAndGraphs._04_02MinimalTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary._04TreesAndGraphs._04_05ValidateBST
{
    /* Validate BST: Implement a function to check if a binary tree is a binary search tree
     * 
     * Solution discussion:
     * Two steps:
     * a> Leverage the in-order traversal
     * b> Build off the property left <= current < right
     * 
     * APPROACH 1:
     * **********
     * First thought might be to do an in-order traversal, copy the elements to an array,
     * and check to see if the array is sorted. This solution takes up a bit of extra mermory,
     * but it works -- mostly.
     * 
     * The only problem is that it cannot handle duplicate values in the tree properly.
     * For example, the algo cannot distinguish two trees below.
     * a> One with 20 as parent and 20 as left child.
     * b> One with 20 as parent and 20 as right child.
     * 
     * This approach 1 can be implemented if we assume that the tree cannot have duplicate
     * values, then this approach works.
     * 
     */
    public class ValidateBST
    {
        private int index = 0;

        #region APPROACH 1: By Copying Tree to array using In-Order traversal approach.
        /// <summary>
        /// In-order traversal and copy data of each node to array.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="array"></param>
        public void CopyBST(TreeNode root, int[] array)
        {
            if (root == null) return; // Base condition

            CopyBST(root.Left, array);
            array[index] = root.Data;
            index++;
            CopyBST(root.Right, array);
        }

        public bool CheckBSTApproach1(TreeNode root, int numberOfNodes)
        {
            int[] array = new int[numberOfNodes];
            CopyBST(root, array);

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] >= array[i]) return false;
            }

            return true;
        }
        #endregion
    }
}
