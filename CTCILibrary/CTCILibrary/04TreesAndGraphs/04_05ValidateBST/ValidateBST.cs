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
     *              Valid BST           Invalid BST
     *                 20                   20
     *                /                       \
     *               /                         \
     *              20                          20
     *              
     * This approach 1 can be implemented if we assume that the tree cannot have duplicate
     * values, then this approach works.
     * 
     * APPROACH 2:
     * **********
     * When we examine this solution, we find that the array is not actually necessary. 
     * We never use it other than to compare an element to the previous element. So why
     * no just track the last element we saw and compare it as we go?
     * 
     * 
     * APPROACH 3 (Last One):
     * **********
     * What does it mean for a tree to be a binary search tree? We know that it must,
     * of course, satisfy the condition left.data <= current.data < right for each node,
     * but this isn't quite sufficient. Consider the following small tree:
     *                  20
     *                /   \
     *               /     \
     *              10      30
     *                \
     *                 \
     *                  25
     *  
     * Although each node is bigger than its left node and smaller than its right node, 
     * this is clearly not a binary search tree since 25 is in the wrong place.
     * 
     * More precisely, the condition is that all left nodes must be less than or equal to
     * the current node, which must be less than all the right nodes.
     * 
     * Using this thought, we can approach the problem by passing down the min and max values.
     * As we iterate through the tree, we verify against progressively narrower ranges.
     * Consider the following sample tree:
     * 
     *                                          20
     *                                         /  \
     *                                        /    \
     *                                       10     30
     *                                      /  \
     *                                     /    \
     *                                    5     15
     *                                   / \      \
     *                                  /   \      \
     *                                 3     7      17
     *                                 
     * We start with a range of (min = NULL, max = NULL), which the root obviously meets.
     * (NULL indicates that there is no min or max). 
     * We then branch left, checking that these nodes are within the range (min = NULL, max = 20).
     * Then, we branch right, checking that the nodes are within the range (min = 20, max = NULL).
     * 
     * We proceed through the tree with this approach. When we branch left, the max gets updated.
     * When we branch right, the min gets updated. If anything fails these checks, we stop and return false.
     * The time complexity for this solution is O(N), where N is the number of nodes in the tree. WE can prove 
     * that this is the best we can do, since any algorithm must touch all N nodes.
     * 
     * Due to the use of recursion, the space complexity is O(log N) on a balanced tree. There are
     * up to O(log N) recursive calls on the stack since we may recurse up to the depth of the tree.
     */
    public class ValidateBST
    {
        private int index = 0;
        private int? lastPrinted = null;

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

        #region APPROACH 2 (Enhancement to previous approach): Keeping track of previous element.
        public bool CheckBSTApproach2(TreeNode n)
        {
            if (n == null) return true;

            // Check / recurse left
            if (!CheckBSTApproach2(n.Left)) return false;

            // Check current
            if (lastPrinted.HasValue && n.Data <= lastPrinted)
            {
                return false;
            }
            lastPrinted = n.Data;

            // Check / recurse right
            if (!CheckBSTApproach2(n.Right)) return false;

            return true; // All Good!
        }
        #endregion

        #region APPROACH 3: Using min/max solution
        public bool CheckBSTApproach3(TreeNode n)
        {
            return CheckBSTApproach3(n, null, null);
        }

        public bool CheckBSTApproach3(TreeNode n, int? min, int? max)
        {
            if (n == null)
            {
                return true;
            }

            if ((min != null && n.Data <= min.Value) || (max != null && n.Data > max.Value))
            {
                return false;
            }

            if (!CheckBSTApproach3(n.Left, min, n.Data) || !CheckBSTApproach3(n.Right, n.Data, max))
            {
                return false;
            }

            return true;
        }
        #endregion
    }
}
