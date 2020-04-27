using CTCILibrary._03StackAndQueues._03_03StackOfPlates;
using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary._03StackAndQueues._03_05SortStack
{
    public class SortStack
    {
        public void Sort(Stack s)
        {
            Stack tempStack = new Stack(25);

            while (!s.IsEmpty())
            {
                int temp = s.Pop();
                if (!tempStack.IsEmpty())
                {
                    while (!tempStack.IsEmpty() && tempStack.Peek() > temp)
                    { 
                        s.Push(tempStack.Pop());                        
                    }
                }
                tempStack.Push(temp);                
            }

            while (!tempStack.IsEmpty())
            {
                s.Push(tempStack.Pop());
            }
        }
    }
}
