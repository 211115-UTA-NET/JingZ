using System;

namespace InheritancePractice
{
    class Inheritance
    {
        public static void Main(string[] args) {
            Console.WriteLine("--- Teacher class extends Employee class ---");
            Teacher Lu = new Teacher("Science", "I.S. 220", 18.5, 40, "Yu", "Lu");
            Lu.Introduce();
            Lu.myWork();

            Console.WriteLine("--- default class ---");
            Teacher Max = new Teacher();
            Max.Introduce();
            Max.myWork();

            Console.WriteLine("--- FeiZhai class extends Person class ---");
            Console.WriteLine("--- default name and habit ---");
            FeiZhai feiZhai2 = new FeiZhai();
            feiZhai2.Introduce();   // default name
            feiZhai2.DailyEvent();
            Console.WriteLine("--- default habit ---");
            FeiZhai feiZhai = new FeiZhai("Bob", "Lopin");
            feiZhai.Introduce();
            feiZhai.DailyEvent();   // default habit
            Console.WriteLine("--- setting habit and name ---");
            FeiZhai feiZhai3 = new FeiZhai("Study, Study, and Study.", "Maxine", "Zhuang");
            feiZhai3.Introduce();   // default name
            feiZhai3.DailyEvent();
        }
    }
}