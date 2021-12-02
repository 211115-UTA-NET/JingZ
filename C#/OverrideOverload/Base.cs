using System;
namespace OverrideOverload
{
    public class Base{
        private string baseString;
        /*  
            Overloading - create multiple versions of a method or constructor, 
            that accept different parameters and accomplish the same task.
            must be the same method name, different params/return types
            Cannot be same params, different return type
        */
        public Base()
        {
            this.baseString = "This is Base string";
        }
        public Base(string baseString){
            this.baseString = baseString;
        }
        public void speak(){
            Console.WriteLine($"Defualt Speaking {baseString}");
        }
        public void speak(string type){
            Console.WriteLine($"Speaking {type}");
        }
        public string speak(string type, int num){
            return $"You said {type} and {num}";
        }
        /* 
            Override must be same method and same params/return types
            The method must have Virtual or Abstract keyword to get Override
                virtual: allow a method to be override by derived class
                abstract:
        */
        public virtual void OverrideMethod(){
            Console.WriteLine("Running Base OverrideMethod...");
        }
    }
}