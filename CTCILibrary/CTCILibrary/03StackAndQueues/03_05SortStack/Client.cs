using System;
using System.Collections.Generic;
using System.Text;
using CTCILibrary._03StackAndQueues._03_03StackOfPlates;

namespace CTCILibrary._03StackAndQueues._03_05SortStack
{
    public class Client
    {
        public void Run()
        {
            Stack s = new Stack(25);
            s.Push(25);
            s.Push(21);
            s.Push(27);
            s.Push(1);
            s.Push(5);
            s.Push(35);
            s.Push(2);
            s.Push(7);            
            s.Push(12);

            SortStack sortStack = new SortStack();
            sortStack.Sort(s);
        }
    }
}
