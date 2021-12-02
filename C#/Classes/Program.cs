using System;

namespace MyClasses
{
    class Classes
    {
        public static void Main(string[] args){
            Console.WriteLine("Hello World");
            Person newGuy = new Person("Joe", "Killer");
            newGuy.Introduce();
            newGuy.setFirstName("Bob");
            Console.WriteLine($"NEW FIRST NAME IS {newGuy.getFirstName()}");
            newGuy.Introduce();
            // Console.WriteLine(newGuy.firstName);  //ERROR! CANNOT CALL PRIVATE 
            Console.WriteLine("----------------Inheritance-----------------");
            Employee worker = new Employee(30, 15.0, "Abby", "Marker");
            worker.Introduce(); // calling Parent class method
            worker.doWork();
            Console.WriteLine("--- Default Contructor ---");
            Employee worker2 = new Employee();
            worker2.Introduce();
            worker2.doWork();
            Console.WriteLine("--- Getter and Setter ---");
            worker2.HoursWorked = 45;   // setter
            worker2.PayRate = 33.7;     // setter
            worker2.doWork();
            Console.WriteLine("My worked hour is " + worker2.HoursWorked);  // getter
            Console.WriteLine("My Pay Rate is " + worker2.PayRate);  // getter
            Console.WriteLine("--- Multi-Inheritance ---");
            Trainee Melinda = new Trainee();
            Melinda.setFirstName("Melinda");    // call parent's parent method
            Melinda.Introduce();    // call parent method 
            Melinda.doWork();   // call parent method 
            Console.WriteLine("Is training? " + Melinda.inTraining);
            Customer Howard = new Customer(333, "Grate", "Howard");
            Howard.Introduce();
            Console.WriteLine("Cash on hand: " + Howard.CashOnHand);
        }
    }
}