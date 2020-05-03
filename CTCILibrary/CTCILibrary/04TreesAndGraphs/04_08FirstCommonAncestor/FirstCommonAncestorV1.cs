using CTCILibrary._04TreesAndGraphs._04_06Successor;
using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary._04TreesAndGraphs._04_08FirstCommonAncestor
{
    public class FirstCommonAncestorV1
    {
        public TreeNode CommonAncestor(TreeNode p, TreeNode q)
        {
            int delta = Depth(p) - Depth(q); // get difference in depths
            TreeNode first = delta > 0 ? q : p; // get shallower node
            TreeNode second = delta > 0 ? p : q; // get deeper node
            second = GoUpBy(second, Math.Abs(delta)); // move deeper node up

            // Find where paths intersect
            while (first != second && first != null && second != null)
            {
                first = first.Parent;
                second = second.Parent;
            }

            return (first == null || second == null) ? null : first;
        }

        private TreeNode GoUpBy(TreeNode node, int delta)
        {
            while (delta > 0 && node != null)
            {
                node = node.Parent;
                delta--;
            }
            return node;
        }

        private int Depth(TreeNode node)
        {
            int depth = 0;
            while (node != null)
            {
                node = node.Parent;
                depth++;
            }
            return depth;
        }
    }
}
