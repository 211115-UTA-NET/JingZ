using System;

namespace CastConvPars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Casting: changing the type but doesn't change the value stored
            Console.WriteLine("------------------ Casting ------------------");
            string start = "Begin";
            Object obj = start;
            string end = (string) obj;
            Console.WriteLine("casting Object type to string type: " + end + ", Type = " + end.GetType());
            // Conversion: may change the value stored --> double to int
            Console.WriteLine("------------------ Conversion ------------------");
            int a = 254;      // -2^31 ~ +2^31
            byte b = (byte)a;   // 0-255
            // Console.WriteLine(a % 256);
            Console.WriteLine("The value of a is [" + a + "] with type [" + a.GetType() + "]");
            Console.WriteLine("The value of b is [" + b + "] with type [" + b.GetType() + "]");
            // Parsing: reads a string as numerical value
            Console.WriteLine("------------------ Parsing ------------------");
            bool res;
            int parsedString;
            Console.Write("Enter some string: ");
            string str = Console.ReadLine();
            res = int.TryParse(str, out parsedString);
            Console.WriteLine("String could be parsed: " + res);
            if(res){
                parsedString = int.Parse(str);
                Console.WriteLine("parsedString [" + parsedString.GetType() + "] --> " + parsedString);
            } else{
                Console.WriteLine("Unable to parsed.");
            }
        }
    }
}
