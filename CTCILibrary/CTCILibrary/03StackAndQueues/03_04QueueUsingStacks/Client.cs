using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary._03StackAndQueues._03_04QueueUsingStacks
{
    public class Client
    {
        public void Run()
        {
            QueueUsingStack queueUsingStack = new QueueUsingStack(25);

            queueUsingStack.EnqueueMethod1(1);
            queueUsingStack.EnqueueMethod1(2);
            queueUsingStack.EnqueueMethod1(3);
            queueUsingStack.EnqueueMethod1(4);
            queueUsingStack.EnqueueMethod1(5);
            queueUsingStack.EnqueueMethod1(6);
            queueUsingStack.EnqueueMethod1(7);
            queueUsingStack.EnqueueMethod1(8);
            queueUsingStack.EnqueueMethod1(9);
            queueUsingStack.EnqueueMethod1(10);

            Console.WriteLine("Dequeue: " + queueUsingStack.DequeueMethod1());
            Console.WriteLine("Dequeue: " + queueUsingStack.DequeueMethod1());
            Console.WriteLine("Dequeue: " + queueUsingStack.DequeueMethod1());
            Console.WriteLine("Dequeue: " + queueUsingStack.DequeueMethod1());
            Console.WriteLine("Dequeue: " + queueUsingStack.DequeueMethod1());

            queueUsingStack = new QueueUsingStack(25);

            queueUsingStack.EnqueueMethod2(1);
            queueUsingStack.EnqueueMethod2(2);
            queueUsingStack.EnqueueMethod2(3);
            queueUsingStack.EnqueueMethod2(4);
            queueUsingStack.EnqueueMethod2(5);
            queueUsingStack.EnqueueMethod2(6);
            queueUsingStack.EnqueueMethod2(7);
            queueUsingStack.EnqueueMethod2(8);
            queueUsingStack.EnqueueMethod2(9);
            queueUsingStack.EnqueueMethod2(10);

            Console.WriteLine("Dequeue: " + queueUsingStack.DequeueMethod2());
            Console.WriteLine("Dequeue: " + queueUsingStack.DequeueMethod2());
            Console.WriteLine("Dequeue: " + queueUsingStack.DequeueMethod2());
            Console.WriteLine("Dequeue: " + queueUsingStack.DequeueMethod2());
            Console.WriteLine("Dequeue: " + queueUsingStack.DequeueMethod2());
        }
    }
}
