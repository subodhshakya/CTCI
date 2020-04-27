using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary._03StackAndQueues._03_06AnimalShelter
{
    public class Client
    {
        public void Run()
        {
            AnimalShelter animalShelter = new AnimalShelter();
            animalShelter.Enqueue(new Dog("Oreo"));
            animalShelter.Enqueue(new Dog("Oscar"));
            animalShelter.Enqueue(new Cat("Biru"));
            animalShelter.Enqueue(new Cat("Kitty"));
            animalShelter.Enqueue(new Dog("Milo"));
            animalShelter.Enqueue(new Cat("Coco"));

            Console.WriteLine(animalShelter.DequeueAny().GetName()); // Oreo
            Console.WriteLine(animalShelter.DequeueCat().GetName()); // Biru
            Console.WriteLine(animalShelter.DequeueDog().GetName()); // Oscar
            Console.WriteLine(animalShelter.DequeueAny().GetName()); // Kitty
        }
    }
}
