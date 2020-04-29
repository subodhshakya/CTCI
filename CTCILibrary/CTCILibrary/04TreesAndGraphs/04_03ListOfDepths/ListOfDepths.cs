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
        public List<LinkedList<TreeNode>> CreateLevelLinkedList(TreeNode rootNode)
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
    }
}
