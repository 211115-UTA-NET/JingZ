using System;

namespace StringManipulationChallenge
{
    public class Program
    {
        static void Main(string[] args)
        {
            string userInputString; //this will hold your users message
            int elementNum;         //this will hold the element number within the messsage that your user indicates
            char char1;             //this will hold the char value that your user wants to search for in the message.
            string fName;           //this will hold the users first name
            string lName;           //this will hold the users last name
            string userFullName;    //this will hold the users full name;
            //
            //
            //implement the required code here and within the methods below.
            //
            //
            Console.WriteLine("Please enter your message and press enter");
            userInputString = Console.ReadLine();
            Console.WriteLine("Please enter a number LESS THAN the length of your string and press enter");
            elementNum = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Upper case your input: " + StringToUpper(userInputString));
            Console.WriteLine("Lower case your input: " + StringToLower(userInputString));
            string str = "                 hello world";
            Console.WriteLine("String before Trim: \"" + str + "\"");
            Console.WriteLine("String after Trim: \"" + StringTrim(str) + "\"");
            Console.WriteLine("Substring your input: " + StringSubstring(userInputString, elementNum));
            Console.WriteLine("----------------------------------");

            Console.WriteLine("For which character should I search in your original message?");
            char1 = char.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Index of the search result is: " + SearchChar(userInputString, char1));
            Console.WriteLine("----------------------------------");

            Console.Write("Enter Your First Name: ");
            fName = Console.ReadLine();
            Console.Write("Enter Your Last Name: ");
            lName = Console.ReadLine();
            Console.WriteLine("----------------------------------");
            userFullName =  ConcatNames(fName, lName);
            Console.WriteLine("Your Full Name is " + userFullName);
            Console.ReadLine();
        }

        // This method has one string parameter. 
        // It will:
        // 1) change the string to all upper case, 
        // 2) print the result to the console and 
        // 3) return the new string.
        public static string StringToUpper(string x){
            // throw new NotImplementedException("StringToUpper method not implemented.");
            return x.ToUpper();
        }

        // This method has one string parameter. 
        // It will:
        // 1) change the string to all lower case, 
        // 2) print the result to the console and 
        // 3) return the new string.        
        public static string StringToLower(string x){
            //throw new NotImplementedException("StringToUpper method not implemented.");
            return x.ToLower();
        }
        
        // This method has one string parameter. 
        // It will:
        // 1) trim the whitespace from before and after the string, 
        // 2) print the result to the console and 
        // 3) return the new string.
        public static string StringTrim(string x){
            //throw new NotImplementedException("StringTrim method not implemented.");
            return x.Trim();
        }
        
        // This method has two parameters, one string and one integer. 
        // It will:
        // 1) get the substring based on the integer received, 
        // 2) print the result to the console and 
        // 3) return the new string.
        public static string StringSubstring(string x, int elementNum){
            //throw new NotImplementedException("StringSubstring method not implemented.");
            return x.Substring(0, elementNum);
        }

        // This method has two parameters, one string and one char.
        // It will:
        // 1) search the string parameter for the char parameter
        // 2) return the index of the char.
        public static int SearchChar(string userInputString, char x){
            // throw new NotImplementedException("SearchChar method not implemented.");
            return userInputString.IndexOf(x);
        }

        // This method has two string parameters.
        // It will:
        // 1) concatenate the two strings with a space between them.
        // 2) return the new string.
        public static string ConcatNames(string fName, string lName){
            //throw new NotImplementedException("ConcatNames method not implemented.");
            return fName + " " + lName;
        }



    }//end of program
}
