using System;
namespace InheritancePractice
{ 
    class FeiZhai: Person{
        string habit { get; set; } = "Do Nothing";
        public FeiZhai(){
            this.habit = "Eat, Play, Sleep.";
        }
        public FeiZhai(string firstName, string lastName) : base(firstName,lastName) {}
        public FeiZhai(string habit, string firstName, string lastName) : base(firstName, lastName) {
            this.habit = habit;
        }

        public void DailyEvent(){
            Console.WriteLine("My daily event is " + habit);
        }
    }
}