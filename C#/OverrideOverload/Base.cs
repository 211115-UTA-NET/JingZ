using System;
namespace OverrideOverload
{
    // contain abstract method, then this class is a public abstract method by default
    public abstract class Base : Test{ // abstract CANNOT extend a non-abstract class.
        private string baseString;
        protected int x = 100;
        protected int y = 200;
        public abstract int X { get; }
        public abstract int Y { get; }
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
        /* 
            Override must be same method and same params/return types
            The method must have Virtual or Abstract keyword to get Override
                virtual: allow a method to be override by derived class
                abstract: must be override by all derived class
        */
        public virtual void OverrideMethod(){
            Console.WriteLine("Running Base OverrideMethod...");
        }

        public abstract void AbstractMethod();
    }
}