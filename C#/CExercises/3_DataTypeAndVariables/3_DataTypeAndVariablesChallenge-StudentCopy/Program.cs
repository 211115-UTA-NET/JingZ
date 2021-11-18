using System;

namespace _3_DataTypeAndVariablesChallenge
{
    public class Program
    {
      public static void Main(string[] args)
      {

            byte myByte = 3;
            sbyte mySbyte = -3;
            int myInt = 656;
            uint myUint = 389;
            short myShort = 125;
            ushort myUShort = 546;
            float myFloat = 998.99f;
            double myDouble = 123.7;
            char myCharacter = 'A';
            bool myBool = true;
            string myText = "I control text";
            string numText = "5465498";

            Console.WriteLine("myByte = " + myByte);
            Console.WriteLine("mysByte = " + mySbyte);
            Console.WriteLine("myUInt = " + myUint);
            Console.WriteLine("myUShort = " + myUShort);
            Console.WriteLine("myFloat = " + myFloat);
            Console.WriteLine("myDouble = " + myDouble);
            Console.WriteLine("myCharacter = " + myCharacter);
            Console.WriteLine("myText = " + myText);
            Console.WriteLine("myInt was = " + myInt);
            Console.WriteLine("myBool was = " + myBool);
            Console.Write("Tring to parse string to int... ");
            myBool = int.TryParse(numText, out myInt);
            Console.WriteLine("myBool now = " + myBool);
            Console.WriteLine("myInt now = " + myInt);
        }

      public static int Text2Num(string numText)
      {
        throw new NotImplementedException();
      }
    }
}
