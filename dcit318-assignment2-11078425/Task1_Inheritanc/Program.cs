using System;

namespace Task1_Inheritance
{
    class Animal
    {
        public virtual void MakeSound() => Console.WriteLine("Some generic sound");
    }

    class Dog : Animal
    {
        public override void MakeSound() => Console.WriteLine("Bark");
    }

    class Cat : Animal
    {
        public override void MakeSound() => Console.WriteLine("Meow");
    }

    class Program
    {
        static void Main()
        {
            Animal genericAnimal = new();
            Dog dog = new();
            Cat cat = new();

            genericAnimal.MakeSound();
            dog.MakeSound();
            cat.MakeSound();
        }
    }
}
