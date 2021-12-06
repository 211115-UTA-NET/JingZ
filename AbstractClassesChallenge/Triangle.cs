using System;

namespace AbstractClassesChallenge
{
    public class Triangle : Shape
    {
        // Implement your Triangle class here.
        // HINT: Use Herons Formula to calculate and set the area.
        // s = (a+b+c)/2
        // area = sqr(s(s-a)(s-b)(s-c))
        double a = 0, b = 0, c = 0;
        public Triangle(double a, double b, double c, string Name, int NumSides) : base(Name, NumSides){
            this.a = a;
            this.b = b;
            this.c = c;
            this.SetArea();
        }
        protected override void SetArea(){
            double s = (a + b + c) / 2;
            base.Area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        public override void GetSidesInfo(){
            Console.WriteLine($"Your {base.Name} has sides {a}, {b}, and {c}.");
        }
        public override void GetAreaFormula()
        {
            Console.WriteLine($"Area formula for {base.Name}:\ns = ({a}+{b}+{c})/2\nArea = √(s(s-{a})(s-{b})(s-{c}))");
        }
    }
}
