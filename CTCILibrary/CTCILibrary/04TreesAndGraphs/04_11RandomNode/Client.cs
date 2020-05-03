using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary._04TreesAndGraphs._04_11RandomNode
{
    public class Client
    {
        public void Run()
        {
            Tree randomTree = new Tree();
            randomTree.InsertInOrder(20);
            randomTree.InsertInOrder(10);
            randomTree.InsertInOrder(30);
            randomTree.InsertInOrder(5);
            randomTree.InsertInOrder(15);
            randomTree.InsertInOrder(35);
            randomTree.InsertInOrder(3);
            randomTree.InsertInOrder(7);
            randomTree.InsertInOrder(17);

            TreeNode randomNode = randomTree.GetRandomNode();
        }
    }
}
