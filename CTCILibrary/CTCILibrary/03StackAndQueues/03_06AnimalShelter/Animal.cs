using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary._03StackAndQueues._03_06AnimalShelter
{
    abstract public class Animal
    {
        private int order;
        protected string name;
        public Animal(string n)
        {
            this.name = n;
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetOrder(int ord)
        {
            this.order = ord;
        }

        public int GetOrder()
        {
            return this.order;
        }

        public bool IsOlderThan(Animal a)
        {
            return this.order < a.GetOrder();
        }
    }

    public class Dog : Animal
    {
        public Dog(string n) : base(n)
        {

        }
    }

    public class Cat : Animal
    {
        public Cat(string n) : base(n)
        {

        }
    }
}
