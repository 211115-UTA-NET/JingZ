using System;

namespace AbstractClassesChallenge
{
    public class Rectangle : Shape
    {
        // Implement your Rectangle class here.
        double width = 0;
        double length = 0;
        public Rectangle(double length, double width, string Name, int NumSides) : base(Name, NumSides){
            this.length = length;
            this.width = width;
            this.SetArea();
        }
        protected override void SetArea(){
            base.Area = this.length * this.width;
        }
        public override void GetSidesInfo(){
            Console.WriteLine($"Your {base.Name} has sides {width} and {length}.");
        }
        public override void GetAreaFormula()
        {
            Console.WriteLine($"Area formula for {base.Name}:\nArea = {width} x {length}");
        }
    }
}
