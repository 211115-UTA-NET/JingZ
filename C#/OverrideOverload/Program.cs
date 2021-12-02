using System;
namespace OverrideOverload
{
    class Program{
        public static void Main(string[] args)
        {
            Base myBase = new Base();
            Console.WriteLine("--- Overloading ---");
            myBase.speak();
            myBase.speak("hello");
            Console.WriteLine(myBase.speak("how are you?", 3));
            Console.WriteLine("--- Overriding ---");
            myBase.OverrideMethod();
            Derived myDerived = new Derived();
            myDerived.OverrideMethod();
            SecondDerived mySecondDerived = new SecondDerived();
            mySecondDerived.OverrideMethod();
        }
    }
}