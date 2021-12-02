using System;
namespace OverrideOverload
{ 
    class SecondDerived : Base{
        public string secondDerivedString { get; set; }
        public SecondDerived(){
            // x = 3;
            // y = 9;
            this.secondDerivedString = "Second Derived";
        }
        // To override a method must add override keyword
        public override void OverrideMethod(){
            Console.WriteLine("Running Second Derived OverrideMethod...");
        }
        // override abstract method
        public override void AbstractMethod(){
            Console.WriteLine("Running Second Derived AbstractMethod...");
        }
        // override abstract properties
        public override int X {
            get {
                return x + 10;
            }
        }
        public override int Y {
            get {
                return y + 10;
            }
        }
    }
}