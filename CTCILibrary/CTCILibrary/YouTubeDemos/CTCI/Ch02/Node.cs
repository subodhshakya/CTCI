using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.Ch02
{
    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }

        public Node(int data)
        {
            this.Data = data;
        }
    }

}
