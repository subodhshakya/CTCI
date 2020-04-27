using CTCILibrary._03StackAndQueues._03_03StackOfPlates;
using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary._03StackAndQueues._03_06AnimalShelter
{
    public class AnimalShelter
    {
        LinkedList<Dog> dogs = new LinkedList<Dog>();
        LinkedList<Cat> cats = new LinkedList<Cat>();
        private int order = 0; // acts as timestamp

        public void Enqueue(Animal a)
        {
            a.SetOrder(order);
            order++;

            if (a is Dog)
            {
                dogs.AddLast((Dog)a);
            }
            else if (a is Cat)
            {
                cats.AddLast((Cat)a);
            }
        }

        public Animal DequeueAny()
        {
            if (dogs.Count == 0)
            {
                return DequeueCat();
            }
            else if (cats.Count == 0)
            {
                return DequeueDog();
            }
            else
            {
                Dog dog = dogs.First.Value;
                Cat cat = cats.First.Value;

                if (dog.IsOlderThan(cat))
                {
                    return DequeueDog();
                }
                else
                {
                    return DequeueCat();
                }
            }
        }

        public Dog DequeueDog()
        {
            Dog d = dogs.First.Value;
            dogs.RemoveFirst();
            return d;
        }

        public Cat DequeueCat()
        {
            Cat c = cats.First.Value;
            cats.RemoveFirst();
            return c;
        }
    }
}
