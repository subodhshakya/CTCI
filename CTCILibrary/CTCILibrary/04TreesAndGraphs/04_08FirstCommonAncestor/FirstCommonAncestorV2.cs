using CTCILibrary._04TreesAndGraphs._04_06Successor;
using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary._04TreesAndGraphs._04_08FirstCommonAncestor
{
    public class FirstCommonAncestorV2
    {
        public TreeNode CommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            // Check if either node is not in the tree, or if one covers the other
            if (!Covers(root, p) || !Covers(root, q))
            {
                return null;
            }
            else if (Covers(p, q))
            {
                return p;
            }
            else if (Covers(q, p))
            {
                return q;
            }

            // Traverse upward until you find a node that covers q
            TreeNode sibling = GetSibling(p);
            TreeNode parent = p.Parent;
            while (!Covers(sibling, q))
            {
                sibling = GetSibling(parent);
                parent = parent.Parent;
            }

            return parent;
        }

        private bool Covers(TreeNode root, TreeNode p)
        {
            if (root == null) return false;
            if (root == p) return true;

            return Covers(root.Left, p) || Covers(root.Right, p);
        }

        private TreeNode GetSibling(TreeNode node)
        {
            if (node == null || node.Parent == null)
            {
                return null;
            }
            TreeNode parent = node.Parent;
            if (parent != null)
            {
                if (node == parent.Left)
                {
                    return parent.Right;
                }
                else
                {
                    return parent.Left;
                }
            }
            return null;
        }
    }
}
