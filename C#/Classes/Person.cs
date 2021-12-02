using System;
// Moved to Person.cs, able to use it when namespace is the same.
namespace MyClasses
{
    public class Person{
        string firstName;    //no modifier defualt private
        string lastName;    // default private
        //Constructor
        public Person(){
            firstName = "John";
            lastName = "Doe";
        }
        public Person(string first, string last){
            firstName = first;
            lastName = last;
        }

        public void setFirstName(string name){
            firstName = name;
        }
        public string getFirstName(){
            return firstName;
        }
        internal void Introduce(){
            Console.WriteLine($"Hello, my name is {firstName} {lastName}");
        }
    }
}