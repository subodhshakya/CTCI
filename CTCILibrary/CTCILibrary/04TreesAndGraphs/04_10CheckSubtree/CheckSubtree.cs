using CTCILibrary._04TreesAndGraphs._04_06Successor;
using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary._04TreesAndGraphs._04_10CheckSubtree
{
    public class CheckSubtree
    {
        public bool ContainsTree(TreeNode t1, TreeNode t2)
        {
            StringBuilder string1 = new StringBuilder();
            StringBuilder string2 = new StringBuilder();

            GetOrderString(t1, string1);
            GetOrderString(t2, string2);

            return (string1.ToString().IndexOf(string2.ToString())) != -1;
        }

        private void GetOrderString(TreeNode node, StringBuilder sb)
        {
            if (node == null)
            {
                sb.Append("X");             // Add null indicator
                return;
            }

            sb.Append(node.Data + " ");     // Add root
            GetOrderString(node.Left, sb);  // Add left
            GetOrderString(node.Right, sb); // Add right
        }
    }
}