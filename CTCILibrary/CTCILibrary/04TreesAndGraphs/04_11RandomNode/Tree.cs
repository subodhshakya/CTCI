using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary._04TreesAndGraphs._04_11RandomNode
{
    public class Tree
    {
        TreeNode root = null;

        public int Size() { return root == null ? 0 : root.Size(); }

        public TreeNode GetRandomNode()
        {
            if (root == null) return null;

            Random random = new Random();
            int i = random.Next(Size());
            return root.GetIthNode(i);
        }

        public void InsertInOrder(int value)
        {
            if (root == null)
            {
                root = new TreeNode(value);
            }
            else
            {
                root.InsertInOrder(value);
            }
        }
    }
}
