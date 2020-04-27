using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary._03StackAndQueues._03_03StackOfPlates
{
    public class Stack
    {
        private Node top;
        private int capacity;
        private int currentItemCount;

        public Stack(int capacity)
        {
            this.capacity = capacity;
            currentItemCount = 0;
        }

        public bool IsEmpty()
        {
            return top == null;
        }

        public void Push(int data)
        {
            if (IsEmpty())
            {
                top = new Node(data);
            }
            else
            {
                Node newNode = new Node(data);
                newNode.next = top;
                top = newNode;
            }
            currentItemCount++;
        }

        public int Pop()
        {
            if (!IsEmpty())
            {
                int topData = top.data;
                top = top.next;
                currentItemCount--;
                return topData;
            }
            else
            {
                throw new Exception("Stack is Empty!");
            }            
        }

        public int Peek()
        {
            if (!IsEmpty())
            {
                return top.data;
            }
            throw new Exception("Stack is empty!");
        }

        public bool IsFull()
        {
            return currentItemCount >= capacity;
        }
    }
}