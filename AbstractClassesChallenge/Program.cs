using System;

namespace AbstractClassesChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rectangle Area:");
            Rectangle MyRectangle = new Rectangle(3.5, 6, "Rectangle", 4);
            MyRectangle.GetSidesInfo();
            MyRectangle.GetAreaFormula();
            Console.WriteLine($"     = {MyRectangle.GetArea()}");
            MyRectangle.GetInfo();

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Triangle Area:");
            Triangle MyTriangle = new Triangle(5, 4, 3, "Triangle", 3);
            MyTriangle.GetSidesInfo();
            MyTriangle.GetAreaFormula();
            Console.WriteLine($"     = {MyTriangle.GetArea()}");
            MyTriangle.GetInfo();

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Square Area:");
            Square MySquare = new Square(7, "Square", 4);
            MySquare.GetSidesInfo();
            MySquare.GetAreaFormula();
            Console.WriteLine($"     = {MySquare.GetArea()}");
            MySquare.GetInfo();
        }
    }
}
