using System;
namespace OverrideOverload
{
    public class Derived : Base{        
        private string derivedString;
        /*  
            Overloading - create multiple versions of a method or constructor, 
            that accept different parameters and accomplish the same task.
            must be the same method name, different params/return types
            Cannot be same params, different return type
        */
        public Derived()
        {
            this.derivedString = "This is Derived string";
        }
        public Derived(string derivedString){
            this.derivedString = derivedString;
        }
        // To override a method must add override keyword
        public override void OverrideMethod(){
            Console.WriteLine("Running Derived OverrideMethod...");
        }
    }
}