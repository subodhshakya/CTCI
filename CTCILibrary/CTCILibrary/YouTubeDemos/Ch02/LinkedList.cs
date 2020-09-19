using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.Ch02
{
    public class LinkedList
    {
        public Node headNode = null;

        public void Add(int data)
        {
            if (headNode == null)
            {
                headNode = new Node(data);
            }
            else
            {
                Node currentNode = headNode;
                while (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }
                currentNode.Next = new Node(data);
            }
        }

        public void Delete(int data)
        {
            if (headNode == null)
            {
                throw new Exception("Linked list is empty");
            }
            else
            {
                if (headNode.Data == data)
                {
                    headNode = headNode.Next;
                }
                else
                {
                    Node currentNode = headNode;
                    while (currentNode.Next != null)
                    {
                        if (currentNode.Next.Data == data)
                        {
                            currentNode.Next = currentNode.Next.Next;
                            break;
                        }
                        currentNode = currentNode.Next;
                    }
                }
            }
        }

        public void PrintList()
        {
            if (headNode == null)
            {
                throw new Exception("Linked list is empty");
            }
            else
            {
                Node currentNode = headNode;
                while (currentNode != null)
                {
                    Console.WriteLine(currentNode.Data);
                    currentNode = currentNode.Next;
                }
            }
            Console.WriteLine("End of list");
        }

        public void RemoveDuplicates()
        {
            HashSet<int> uniqueNodeData = new HashSet<int>();

            Node currentNode = headNode;
            Node previousNode = null;
            while (currentNode != null)
            {
                if (uniqueNodeData.Contains(currentNode.Data))
                {
                    previousNode.Next = currentNode.Next;
                }
                else
                {
                    uniqueNodeData.Add(currentNode.Data);
                    previousNode = currentNode;
                }
                currentNode = currentNode.Next;
            }
        }

        public void RemoveDuplicatesNoBuffer()
        {
            Node currentNode = headNode;
            while (currentNode != null)
            {
                Node runner = currentNode.Next;
                Node previousNode = currentNode;
                while (runner != null)
                {
                    if (currentNode.Data == runner.Data)
                    {
                        previousNode.Next = runner.Next;
                    }
                    else
                    {
                        previousNode = runner;
                    }
                    runner = runner.Next;
                }
                currentNode = currentNode.Next;
            }
        }

        public int KthToLast(int k)
        {
            Node p1 = headNode;
            Node p2 = headNode;

            for (int i = 0; i < k; i++)
            {
                if (p1 == null)
                {
                    throw new Exception("Out of bound");
                }
                p1 = p1.Next;
            }

            while (p1 != null)
            {
                p1 = p1.Next;
                p2 = p2.Next;
            }

            return p2.Data;
        }

        public bool DeleteMiddleNode(Node n)
        {
            if (n == null || n.Next == null)
            {
                return false;
            }

            Node nxt = n.Next;
            n.Data = nxt.Data;
            n.Next = nxt.Next;
            return true;
        }

        public Node Partition(int x)
        {
            Node beforeStart = null;
            Node beforeEnd = null;
            Node afterStart = null;
            Node afterEnd = null;

            Node current = headNode;
            while (current != null)
            {
                if (current.Data < x)
                {
                    if (beforeStart == null)
                    {
                        beforeStart = beforeEnd = current;
                    }
                    else
                    {
                        beforeEnd.Next = current;
                        beforeEnd = current;
                    }
                }
                else
                {
                    if (afterStart == null)
                    {
                        afterStart = afterEnd = current;
                    }
                    else
                    {
                        afterEnd.Next = current;
                        afterEnd = current;
                    }
                }
                current = current.Next;
            }

            beforeEnd.Next = null;
            afterEnd.Next = null;

            if (beforeEnd == null)
            {
                return afterStart;
            }
            else
            {
                beforeEnd.Next = afterStart;
                return beforeStart;
            }
        }
    }
}
