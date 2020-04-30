using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary._04TreesAndGraphs._04_06Successor
{
    public class Client
    {
        public void Run()
        {
            // Create a tree
            TreeNode n15 = new TreeNode(15);

            TreeNode n10 = new TreeNode(10);
            n10.Parent = n15;
            TreeNode n20 = new TreeNode(20);
            n20.Parent = n15;

            n15.Left = n10;
            n15.Right = n20;

            // Level 2
            TreeNode n08 = new TreeNode(8);
            n08.Parent = n10;

            TreeNode n12 = new TreeNode(12);
            n12.Parent = n10;

            TreeNode n17 = new TreeNode(17);
            n17.Parent = n20;

            TreeNode n25 = new TreeNode(25);
            n25.Parent = n20;

            n10.Left = n08;
            n10.Right = n12;

            n20.Left = n17;
            n20.Right = n25;

            // Level 3
            TreeNode n06 = new TreeNode(6);
            n06.Parent = n08;

            TreeNode n11 = new TreeNode(11);
            n11.Parent = n12;

            TreeNode n16 = new TreeNode(16);
            n16.Parent = n17;

            TreeNode n27 = new TreeNode(27);
            n27.Parent = n25;

            n08.Left = n06;

            n12.Left = n11;

            n17.Left = n16;

            n25.Right = n27;

            Successor successor = new Successor();
            TreeNode nextSuccN10 = successor.InOrderSucc(n10);

            TreeNode nextSuccN08 = successor.InOrderSucc(n08);

            TreeNode nextSuccN12 = successor.InOrderSucc(n12);
        }
    }
}
