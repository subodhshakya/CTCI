using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary._03StackAndQueues._03_03StackOfPlates
{
    public class Client
    {
        public void Run()
        {
            SetOfStacks setOfStacks = new SetOfStacks(3, 5);
            setOfStacks.Push(1);
            setOfStacks.Push(2);
            setOfStacks.Push(3);
            setOfStacks.Push(4);
            setOfStacks.Push(5);
            setOfStacks.Push(6);
            setOfStacks.Push(7);
            setOfStacks.Push(8);
            setOfStacks.Push(9);
            setOfStacks.Push(10);
            setOfStacks.Push(11);
            setOfStacks.Push(12);
            setOfStacks.Push(13);
            setOfStacks.Push(14);
            setOfStacks.Push(15);

            Console.WriteLine("Pop: " + setOfStacks.Pop());
            Console.WriteLine("Pop: " + setOfStacks.Pop());
            Console.WriteLine("Pop: " + setOfStacks.Pop());
            Console.WriteLine("Pop: " + setOfStacks.Pop());
            Console.WriteLine("Pop: " + setOfStacks.Pop());
            Console.WriteLine("Pop: " + setOfStacks.Pop());
            Console.WriteLine("Pop: " + setOfStacks.Pop());
            Console.WriteLine("Pop: " + setOfStacks.Pop());

            Console.WriteLine("Pop At 0 index: " + setOfStacks.PopAt(0));
        }
    }
}
