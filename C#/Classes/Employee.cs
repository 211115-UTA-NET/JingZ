using System;

namespace MyClasses
{
    // Employee extends Person
    public class Employee : Person
    {
        public int HoursWorked { get; set; }
        public double PayRate { get; set; }
        // Contructor
        public Employee() {
            this.HoursWorked = 40;
            this.PayRate = 44.3;
        }
        // the base keyword is used to access members of the base class from within a derived class
        // C# uses "base" keyword whenever Java uses "super"
        public Employee(int HoursWorked, double PayRate, string firstname, string lastname) : base(firstname, lastname){
            this.HoursWorked = HoursWorked;
            this.PayRate = PayRate;  
        }
        public void doWork(){
            Console.WriteLine($"I've worked {HoursWorked} hours with {PayRate}/hr PayRate");
        }
    }
}