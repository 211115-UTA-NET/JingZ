using System;

namespace MyClasses
{ 
    public class Trainee : Employee{
        public bool inTraining{ get; set; }
        public Trainee(){
            this.inTraining = true;
        }
    }
}