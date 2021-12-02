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
            // x = -3;
            // y = -9;
            this.derivedString = "This is Derived string";
        }
        public Derived(string derivedString){
            this.derivedString = derivedString;
        }
        
        public void speak(){
            Console.WriteLine($"Defualt Speaking: {derivedString}");
        }
        public void speak(string type){
            Console.WriteLine($"Speaking: {type}");
        }
        public string speak(string type, int num){
            return $"You said: {type} and {num}";
        }
        // To override a method must add override keyword
        public override void OverrideMethod(){
            Console.WriteLine("Running Derived OverrideMethod...");
        }
        // override abstract method
        public override void AbstractMethod(){
            Console.WriteLine("Running Derived AbstractMethod...");
        }
        // override abstract properties
        public override int X {
            get {
                return x - 10;
            }
        }
        public override int Y {
            get {
                return y - 10;
            }
        }
    }
}