using System;

namespace Task2_Abstract
{
    abstract class Shape
    {
        public abstract double GetArea();
    }

    class Circle(double radius) : Shape
    {
        public double Radius { get; set; } = radius;

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    class Rectangle(double length, double width) : Shape
    {
        public double Length { get; set; } = length;
        public double Width { get; set; } = width;

        public override double GetArea()
        {
            return Length * Width;
        }
    }

    class Program
    {
        static void Main()
        {
            Circle circle = new(5);
            Rectangle rectangle = new(4, 6);

            Console.WriteLine($"Circle Area: {circle.GetArea()}");
            Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");
        }
    }
}
