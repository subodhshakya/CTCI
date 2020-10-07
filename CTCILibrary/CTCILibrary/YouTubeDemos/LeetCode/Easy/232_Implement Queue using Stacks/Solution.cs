using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._232_Implement_Queue_using_Stacks
{
    /*
     * Implement a first in first out (FIFO) queue using only two stacks. The implemented queue should support all the functions of a normal queue (push, peek, pop, and empty).

        Implement the MyQueue class:

        void push(int x) Pushes element x to the back of the queue.
        int pop() Removes the element from the front of the queue and returns it.
        int peek() Returns the element at the front of the queue.
        boolean empty() Returns true if the queue is empty, false otherwise.
        Notes:

        You must use only standard operations of a stack, which means only push to top, peek/pop from top, size, and is empty operations are valid.
        Depending on your language, the stack may not be supported natively. You may simulate a stack using a list or deque (double-ended queue) as long as you use only a stack's standard operations.
        Follow-up: Can you implement the queue such that each operation is amortized O(1) time complexity? In other words, performing n operations will take overall O(n) time even if one of those operations may take longer.

 

        Example 1:

        Input
        ["MyQueue", "push", "push", "peek", "pop", "empty"]
        [[], [1], [2], [], [], []]
        Output
        [null, null, null, 1, 1, false]

        Explanation
        MyQueue myQueue = new MyQueue();
        myQueue.push(1); // queue is: [1]
        myQueue.push(2); // queue is: [1, 2] (leftmost is front of the queue)
        myQueue.peek(); // return 1
        myQueue.pop(); // return 1, queue is [2]
        myQueue.empty(); // return false
 

        Constraints:

        1 <= x <= 9
        At most 100 calls will be made to push, pop, peek, and empty.
     * 
     */
    public class Solution
    {
        public Stack<int> qStack1 { get; set; }
        public Stack<int> qStack2 { get; set; }

        /** Initialize your data structure here. */
        public Solution()
        {
            qStack1 = new Stack<int>();
            qStack2 = new Stack<int>();
        }

        /** Push element x to the back of queue. */
        public void Push(int x)
        {
            while (qStack1.Count > 0)
            {
                qStack2.Push(qStack1.Pop());
            }
            qStack1.Push(x);
            while (qStack2.Count > 0)
            {
                qStack1.Push(qStack2.Pop());
            }
        }

        /** Removes the element from in front of queue and returns that element. */
        public int Pop()
        {
            if (Empty())
                throw new Exception("Queue is empty!");
            else
                return qStack1.Pop();
        }

        /** Get the front element. */
        public int Peek()
        {
            if (Empty())
                throw new Exception("Queue is empty!");
            else
                return qStack1.Peek();
        }

        /** Returns whether the queue is empty. */
        public bool Empty()
        {
            return qStack1.Count == 0;
        }
    }
}
