using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._225_Implement_Stack_using_Queues
{
    /*
     * Implement a last in first out (LIFO) stack using only two queues. The implemented stack should support all the functions of a normal queue (push, top, pop, and empty).

        Implement the MyStack class:

        void push(int x) Pushes element x to the top of the stack.
        int pop() Removes the element on the top of the stack and returns it.
        int top() Returns the element on the top of the stack.
        boolean empty() Returns true if the stack is empty, false otherwise.
        Notes:

        You must use only standard operations of a queue, which means only push to back, peek/pop from front, size, and is empty operations are valid.
        Depending on your language, the queue may not be supported natively. You may simulate a queue using a list or deque (double-ended queue), as long as you use only a queue's standard operations.
        Follow-up: Can you implement the stack such that each operation is amortized O(1) time complexity? In other words, performing n operations will take overall O(n) time even if one of those operations may take longer.

 

        Example 1:

        Input
        ["MyStack", "push", "push", "top", "pop", "empty"]
        [[], [1], [2], [], [], []]
        Output
        [null, null, null, 2, 2, false]
     * 
     */
    class Solution
    {
        public Queue<int> queue1Stack { get; set; }
        public Queue<int> queue2Stack { get; set; }

        /** Initialize your data structure here. */
        public Solution()
        {
            queue1Stack = new Queue<int>();
            queue2Stack = new Queue<int>();
        }

        /** Push element x onto stack. */
        public void Push(int x)
        {
            queue2Stack.Enqueue(x);
            while (queue1Stack.Count > 0)
            {
                queue2Stack.Enqueue(queue1Stack.Dequeue());
            }
            queue1Stack = queue2Stack;
            queue2Stack = new Queue<int>();
        }

        /** Removes the element on top of the stack and returns that element. */
        public int Pop()
        {
            if (queue1Stack.Count > 0)
                return queue1Stack.Dequeue();
            else
                throw new Exception("Stack is empty!");
        }

        /** Get the top element. */
        public int Top()
        {
            if (queue1Stack.Count > 0)
                return queue1Stack.Peek();
            else
                throw new Exception("Stack is empty!");
        }

        /** Returns whether the stack is empty. */
        public bool Empty()
        {
            if (queue1Stack.Count > 0)
                return false;
            return true;
        }
    }
}
