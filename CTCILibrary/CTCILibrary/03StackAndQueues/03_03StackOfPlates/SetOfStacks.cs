using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary._03StackAndQueues._03_03StackOfPlates
{
    public class SetOfStacks
    {
        private Stack[] stacks;
        private int stackLimit;
        private int currentStack;
        private int totalStacks;

        public SetOfStacks(int numberOfStacks, int eachStackCapacity)
        {
            stacks = new Stack[numberOfStacks];
            stackLimit = eachStackCapacity;
            currentStack = 0;
            totalStacks = numberOfStacks;
        }

        public void Push(int data)
        {
            if (stacks[currentStack] == null)
            {
                stacks[currentStack] = new Stack(this.stackLimit);
            }
            if (stacks[currentStack].IsFull())
            {
                currentStack++;
                if (currentStack >= totalStacks)
                {
                    throw new Exception("All stacks are full");
                }

                if (stacks[currentStack] == null)
                {
                    stacks[currentStack] = new Stack(this.stackLimit);
                }
            }
            
            stacks[currentStack].Push(data);
        }

        public int Pop()
        {            
            if (stacks[currentStack].IsEmpty())
            {
                currentStack--;                
            }
            if (currentStack >= 0)
            {
                return stacks[currentStack].Pop();
            }
            else
            {
                throw new Exception("Stack is empty!");
            }
        }

        public int PopAt(int index)
        {
            if (index >= 0 && index < totalStacks)
            {
                return stacks[index].Pop();
            }
            else
            {
                throw new Exception("Index out of range!");
            }
        }
    }
}
