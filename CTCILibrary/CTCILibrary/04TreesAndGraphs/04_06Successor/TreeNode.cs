using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary._04TreesAndGraphs._04_06Successor
{
    public class TreeNode
    {
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }

        public TreeNode Parent { get; set; }
        public int Data { get; set; }

        public TreeNode(int data)
        {
            this.Data = data;
        }
    }
}
