using System;

namespace AbstractClassesChallenge
{
    public class Square : Rectangle
    {
        // Implement your Square Class here.
        double side = 0;
        public Square(double side, string Name, int NumSides) : base(side, side, Name, NumSides) {
            this.side = side;
        }
    }
}
