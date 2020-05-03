using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary._04TreesAndGraphs._04_11RandomNode
{
    public class TreeNode
    {
        public int data;
        private int size = 0;
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }

        public TreeNode(int d)
        {
            this.data = d;
            size = 1;
        }

        public TreeNode GetIthNode(int i)
        {
            int leftSize = Left == null ? 0 : Left.Size();
            if (i < leftSize)
            {
                return Left.GetIthNode(i);
            }
            else if (i == leftSize)
            {
                return this;
            }
            else
            {
                // Skipping over leftsize +1 nodes, so subtract them.
                return Right.GetIthNode(i - (leftSize + 1));
            }
        }

        public int Size() { return size; }        

        public void InsertInOrder(int d)
        {
            if (d <= data)
            {
                if (Left == null)
                {
                    Left = new TreeNode(d);
                }
                else
                {
                    Left.InsertInOrder(d);
                }
            }
            else
            {
                if (Right == null)
                {
                    Right = new TreeNode(d);
                }
                else
                {
                    Right.InsertInOrder(d);
                }
            }
            size++;
        }

        public TreeNode Find(int d)
        {
            if (d == data)
            {
                return this;
            }
            else if (d <= data)
            {
                return Left != null ? Left.Find(d) : null;
            }
            else if (d > data)
            {
                return Right != null ? Right.Find(d) : null;
            }
            return null;
        }
    }
}
