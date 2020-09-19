using CTCILibrary.YouTubeDemos.Ch02._02;
using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.Ch02
{
    class SumList
    {
        public Node SumListReverseOrder(Node l1, Node l2)
        {
            // List1 = 5 -> 2 -> 7
            // List2 = 8 -> 5 -> 2 -> 3

            int carry = 0;
            Node outputListHead = null;
            Node outputListItr = null;
            while (l1 != null || l2 != null)
            {
                int sum = (l1 != null ? l1.Data : 0) + (l2 != null ? l2.Data : 0) + carry;
                carry = 0;
                if (sum > 9)
                {
                    carry = sum / 10;
                }
                int outputData = sum % 10;
                if (outputListHead == null)
                {
                    outputListHead = new Node(outputData);
                    outputListItr = outputListHead;
                }
                else
                {
                    outputListItr.Next = new Node(outputData);
                    outputListItr = outputListItr.Next;
                }
                if (l1 != null)
                {
                    l1 = l1.Next;
                }
                if (l2 != null)
                {
                    l2 = l2.Next;
                }
            }

            return outputListHead;
        }

        public Node SumListForwardOrder(Node l1, Node l2)
        {
            int l1Size = GetSize(l1);
            int l2Size = GetSize(l2);

            if (l1Size < l2Size)
            {
                l1 = PadListAtFront(l1, l2Size - l1Size);
            }
            else if (l2Size < l1Size)
            {
                l2 = PadListAtFront(l2, l1Size - l2Size);
            }

            int carry = 0;
            PartialSum pSum = SumHelper(l1, l2, carry);

            return pSum.node;
        }

        private PartialSum SumHelper(Node n1, Node n2, int carry)
        {
            if (n1 == null && n2 == null)
            {
                PartialSum sum = new PartialSum();
                return sum;
            }
            PartialSum p = SumHelper(n1.Next, n2.Next, carry);
            int total = n1.Data + n2.Data + p.carry;
            Node fullResult = InsertBefore(total % 10, p.node);
            return new PartialSum { node = fullResult, carry = total / 10 };
        }

        private int GetSize(Node h)
        {
            int size = 0;
            Node current = h;
            while (current != null)
            {
                size++;
                current = current.Next;
            }
            return size;
        }

        private Node PadListAtFront(Node h, int nodesCount)
        {
            for (int i = 0; i < nodesCount; i++)
            {
                Node n = new Node(0);
                n.Next = h;
                h = n;
            }
            return h;
        }

        private Node InsertBefore(int data, Node currentHead)
        {
            if (currentHead == null)
            {
                return new Node(data);
            }
            Node n = new Node(data);
            n.Next = currentHead;
            return n;
        }
    }
}
