using System;

namespace InheritancePractice
{ 
    class Teacher : Employee{
        public string teachingSubject { get; set; }
        public string schoolName { get; set; }
        public Teacher(){
            this.teachingSubject = "Math";
            this.schoolName = "MIT";
        }
        public Teacher(string teachingSubject, string schoolName, double PayRate, int HoursWorked, string firstName, string lastName) : base(HoursWorked, PayRate, firstName, lastName)
        {
            this.teachingSubject = teachingSubject;
            this.schoolName = schoolName;
        }
        public void myWork(){
            base.doWork();
            Console.WriteLine($"I am a {teachingSubject} teacher in {schoolName}.");
        }
    }
}