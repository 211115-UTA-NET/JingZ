using System;
namespace OverrideOverload
{ 
    class SecondDerived : Base{
        private string secondDerivedString;
        public SecondDerived(){
            this.secondDerivedString = "Second Derived";
        }
        // To override a method must add override keyword
        public override void OverrideMethod(){
            Console.WriteLine("Running Second Derived OverrideMethod...");
        }
    }
}