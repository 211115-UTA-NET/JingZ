using System;

namespace SampleNamespace
{
    class Parent
    {
        private int number = 9002584;     // current class only
        protected int id { get; set; }  // can access in current class or derived class (in/out assembly)
        internal int ssn = 1567892165;  // can access in current assembly
    }
    class Child:Parent
    {
        public static void Main(string[] args)
        {
            Child c = new Child();  // when derived from parent class, create child class obj to call parent props/behvr
            c.id = 188;
            Console.WriteLine("Protected var in parent: " + c.id);
            Console.WriteLine("Internal var in parent: " + c.ssn);
            // Parent p = new Parent();
            // p.id = 188;
            // Console.WriteLine("Protected var in parent: " + p.id);
            // Console.WriteLine("Internal var in parent: " + p.ssn);
        }
    }
}