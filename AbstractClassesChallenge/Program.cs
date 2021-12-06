using System;

namespace AbstractClassesChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rectangle Area:");
            Rectangle MyRectangle = new Rectangle(3.5, 6, "Rectangle", 4);
            MyRectangle.GetInfo();
            Console.WriteLine($"Rectangle Area = {MyRectangle.GetArea()}");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Triangle Area:");
            Triangle MyTriangle = new Triangle(5, 4, 3, "Triangle", 3);
            MyTriangle.GetInfo();
            Console.WriteLine($"Triangle Area = {MyTriangle.GetArea()}");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Square Area:");
            Square MySquare = new Square(7, "Square", 4);
            MySquare.GetInfo();
            Console.WriteLine($"Square Area = {MySquare.GetArea()}");
        }
    }
}
