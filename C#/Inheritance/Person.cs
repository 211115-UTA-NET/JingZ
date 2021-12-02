using System;
// Moved to Person.cs, able to use it when namespace is the same.
namespace InheritancePractice
{
    public class Person {
        string firstName { get; set; }    //no modifier defualt private
        string lastName { get; set; }     // default private
        //Constructor
        public Person(){
            firstName = "Helen";
            lastName = "May";
        }
        public Person(string first, string last){
            firstName = first;
            lastName = last;
        }

        internal void Introduce(){
            Console.WriteLine($"Hello. My name is {firstName} {lastName}.");
        }
    }
}