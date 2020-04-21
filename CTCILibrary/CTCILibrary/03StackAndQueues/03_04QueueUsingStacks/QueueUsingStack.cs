using CTCILibrary._03StackAndQueues._03_03StackOfPlates;
using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary._03StackAndQueues._03_04QueueUsingStacks
{
    public class QueueUsingStack
    {
        Stack stackNewest; // Has newest item on top
        Stack stackOldest; // Has oldest item on top

        public QueueUsingStack(int capacity)
        {
            stackNewest = new Stack(capacity * 2);
            stackOldest = new Stack(capacity * 2);
        }

        /// <summary>
        /// O(1)
        /// </summary>
        /// <param name="data"></param>
        public void EnqueueMethod1(int data)
        {
            stackNewest.Push(data);
        }

        /// <summary>
        /// O(n)
        /// </summary>
        /// <returns></returns>
        public int DequeueMethod1()
        {
            if (stackOldest.IsEmpty())
            {
                while (!stackNewest.IsEmpty())
                {
                    stackOldest.Push(stackNewest.Pop());
                }
            }
            return stackOldest.Pop();
        }

        /// <summary>
        /// O(n)
        /// </summary>
        /// <param name="data"></param>
        public void EnqueueMethod2(int data)
        {
            // Move everything to another stack
            while (!stackOldest.IsEmpty())
            {
                stackNewest.Push(stackOldest.Pop());
            }

            // Push to the bottom that is at the end equivalent of queue
            stackOldest.Push(data);

            // Put back everything to oldest first stack (this is queue -- pop equivalent to deque).
            while (!stackNewest.IsEmpty())
            {
                stackOldest.Push(stackNewest.Pop());
            }            
        }

        /// <summary>
        /// O(1)
        /// </summary>
        /// <returns></returns>
        public int DequeueMethod2()
        {
            return stackOldest.Pop();
        }
    }
}
