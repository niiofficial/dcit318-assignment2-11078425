using System;

namespace Task3_Interface
{
    interface IMovable
    {
        void Move();
    }

    class Car : IMovable
    {
        public void Move() => Console.WriteLine("Car is moving");
    }

    class Bicycle : IMovable
    {
        public void Move() => Console.WriteLine("Bicycle is moving");
    }

    class Program
    {
        static void Main()
        {
            Car car = new();
            Bicycle bicycle = new();

            car.Move();
            bicycle.Move();
        }
    }
}
