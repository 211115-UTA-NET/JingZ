using System;
namespace OverrideOverload
{
    // class is internal by default
    class Program{
        public static void Main(string[] args)
        {
            // Base class is an abstract class, cannot create instance
            Derived myDerived = new Derived();
            Console.WriteLine("--- Overloading ---");
            myDerived.speak();
            myDerived.speak("hello");
            Console.WriteLine(myDerived.speak("how are you?", 3));
            Console.WriteLine("--- Overriding ---");
            myDerived.OverrideMethod();
            SecondDerived mySecondDerived = new SecondDerived();
            mySecondDerived.OverrideMethod();
            mySecondDerived.AbstractMethod();
            Console.WriteLine("--- mySecondDerived override properties ---");
            Console.WriteLine("X = " + mySecondDerived.X);
            Console.WriteLine("Y = " + mySecondDerived.Y);
            Console.WriteLine("--- myDerived override properties ---");
            Console.WriteLine("X = " + myDerived.X);
            Console.WriteLine("Y = " + myDerived.Y);
            myDerived.Print();  // call Base parent's parent method
        }
    }
}