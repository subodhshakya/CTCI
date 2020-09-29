using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._155_Min_Stack
{
    public class MinStack
    {
        private MyNode top = null;

        /** initialize your data structure here. */
        public MinStack()
        {

        }

        public void Push(int x)
        {
            if (IsEmpty())
            {
                top = new MyNode(x);
                top.MinValue = x;
            }
            else
            {
                int currentMin = Peek().MinValue;
                MyNode current = new MyNode(x);
                if (x < currentMin)
                {
                    currentMin = x;
                }
                current.MinValue = currentMin;
                current.Next = top;
                top = current;
            }
        }

        public void Pop()
        {
            if (!IsEmpty())
            {
                top = top.Next;
            }
            else
            {
                throw new Exception("Stack is empty!!!");
            }
        }

        public int Top()
        {
            if (!IsEmpty())
            {
                return top.Value;
            }
            else
            {
                throw new Exception("Stack is empty!!!");
            }
        }

        public int GetMin()
        {
            if (!IsEmpty())
            {
                return top.MinValue;
            }
            else
            {
                throw new Exception("Stack is empty!!!");
            }
        }

        private bool IsEmpty()
        {
            if (top == null)
                return true;
            return false;
        }

        private MyNode Peek()
        {
            if (!IsEmpty())
            {
                return top;
            }
            else
            {
                throw new Exception("Stack is empty!!!");
            }
        }
    }

    public class MyNode
    {
        public MyNode Next { get; set; }
        public int Value { get; set; }
        public int MinValue { get; set; }
        public MyNode(int val)
        {
            this.Value = val;
        }
    }

    /**
     * Your MinStack object will be instantiated and called as such:
     * MinStack obj = new MinStack();
     * obj.Push(x);
     * obj.Pop();
     * int param_3 = obj.Top();
     * int param_4 = obj.GetMin();
     */
}
