using CTCILibrary._04TreesAndGraphs._04_02MinimalTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary._04TreesAndGraphs._04_03ListOfDepths
{
    public class ListOfDepths
    {
        /* List of Depths: Given a binary tree, design an algorithm which creates a linked list of all the
         * nodes at each depth (e.g. if you have a tree with depth D, you'll have D linked lists).         
         */

        /// <summary>
        /// Non recursive approach
        /// </summary>
        /// <param name="rootNode"></param>
        /// <returns></returns>
        public List<LinkedList<TreeNode>> CreateLevelLinkedListNonRecursive(TreeNode rootNode)
        {
            List<LinkedList<TreeNode>> result = new List<LinkedList<TreeNode>>();

            LinkedList<TreeNode> current = new LinkedList<TreeNode>();
            if (rootNode != null)
            {
                current.AddLast(rootNode);
            }

            while (current.Count > 0)
            {
                result.Add(current); // Add previous level
                LinkedList<TreeNode> parents = current; // Go to next level
                current = new LinkedList<TreeNode>();
                foreach (TreeNode parent in parents)
                {
                    // Visit the children
                    if (parent.Left != null)
                    {
                        current.AddLast(parent.Left);
                    }
                    if (parent.Right != null)
                    {
                        current.AddLast(parent.Right);
                    }
                }
            }

            return result;
        }

        public List<LinkedList<TreeNode>> CreateLevelLinkedListRecursive(TreeNode rootNode)
        {
            List<LinkedList<TreeNode>> lists = new List<LinkedList<TreeNode>>();
            CreateLevelLinkedList(rootNode, lists, 0);
            return lists;
        }

        public void CreateLevelLinkedList(TreeNode root, List<LinkedList<TreeNode>> lists, int level)
        {
            if (root == null) return; // base case

            LinkedList<TreeNode> list = null;

            if (lists.Count == level)
            {
                list = new LinkedList<TreeNode>();
                // This is just instantiation step to make sure list is not null. Once count of items in list is not equal to level then
                // it is the case that list has already been instantiated.
                lists.Add(list);
            }
            else
            {
                list = lists[level];
            }
            list.AddLast(root);
            CreateLevelLinkedList(root.Left, lists, level + 1);
            CreateLevelLinkedList(root.Right, lists, level + 1);
        }
    }
}