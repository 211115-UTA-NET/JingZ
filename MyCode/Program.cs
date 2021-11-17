using System;
using System.Data;

namespace MyCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an option:");
			Console.WriteLine("1. Looping and Skipping");
			Console.WriteLine("2. Personalized Input");
			Console.WriteLine("3. Looping with numbers");
			Console.WriteLine("4. Simple Arithmetic");
			Console.WriteLine("5. Simple Arithmetic");
			Console.WriteLine("6. Conditions");
			Console.WriteLine("7. More Conditions");
			Console.WriteLine("8. Arithmetic Operations");
			Console.WriteLine("9. Compute the Average");
			Console.Write("\nEnter the number you want to test: ");
			int num = Convert.ToInt32(Console.ReadLine());
			
			switch(num){
				case 1:
					Console.WriteLine("Looping and Skipping:");
					LoopOdd(99);
					break;
				case 2:
					Console.WriteLine("Personalized Input:");
					Console.Write("Enter anything: ");
					string input = Console.ReadLine();
					Console.WriteLine("You entered: " + input);
					break;
				case 3:
					Console.WriteLine();
					Console.WriteLine("Looping with numbers:");
					LoopNum(50);
					break;
				case 4:
					Console.WriteLine("Simple Arithmetic:");
					Console.Write("Enter x: ");
					int x = Convert.ToInt32(Console.ReadLine());
					Console.Write("Enter y: ");
					int y = Convert.ToInt32(Console.ReadLine());
					Calc(x,y);
					break;
				case 5:
					Console.WriteLine("Compare Numbers:");
					Console.Write("Enter x: ");
					int x2 = Convert.ToInt32(Console.ReadLine());
					Console.Write("Enter y: ");
					int y2 = Convert.ToInt32(Console.ReadLine());
					Compare(x2, y2);
					break;
				case 6:
					Console.WriteLine("Conditions:");
					Console.Write("Enter one character [y/n/Y/N] :");
					String condition = Console.ReadLine();
					CheckCond(condition);
					break;
				case 7:
					Console.WriteLine("More Conditions:");
					int[] arr= new int[3];
					for(int i=0; i<3; i++){
						Console.Write("Enter #" + (i+1) + " = ");
						arr[i] = Convert.ToInt32(Console.ReadLine());
					}
					MoreCompare(arr);
					break;
				case 8:
					Console.WriteLine("Arithmetic Operations:");
					Console.Write("Enter math expression: ");
					string str = Console.ReadLine();
					DataTable data = new DataTable();
					double val = Convert.ToDouble(data.Compute(str,""));
					Console.WriteLine(Math.Round(val, 3));	//rounded to 3 decimals
					break;
				case 9:
					Console.WriteLine("Compute the Average:");
					Console.Write("Enter your numbers: ");
					string avg = Console.ReadLine();
					string[] textSplit = avg.Split(" ");
					Console.WriteLine("Average = " + CalcAverage(textSplit));
					break;
				default:
					Console.WriteLine("Option number does not exist");
					break;
			}
        }
		
		static void LoopOdd(int n){
			for(int i=1; i <= n; i+=2){
				Console.WriteLine(i);
			}
		}
		
		static void LoopNum(int n) {
			for(int i=1; i<=n; i++){
				Console.WriteLine(i);
			}
		}
		
		static void Calc(int x, int y){
			Console.WriteLine("x + y = " + (x+y));
			Console.WriteLine("x - y = " + (x-y));
			Console.WriteLine("x * y = " + (x*y));
			if(y!=0){
				Console.WriteLine("x / y = " + (x/y));
			} else {
				Console.WriteLine("Failed to divided by zero.");
			}
		}
		
		static void Compare(int x, int y){
			if(x<y){
				Console.WriteLine("X is less than Y");
			} else if(x==y){
				Console.WriteLine("X is equal to Y");
			} else {
				Console.WriteLine("X is greater than Y");
			}
		}
		
		static void CheckCond(string c){
			if(c == "y" || c == "Y"){
				Console.WriteLine("YES");
			} else if(c == "n" || c == "N"){
				Console.WriteLine("NO");
			} else {
				Console.WriteLine("Wrong input.");
			}
		}
		
		static void MoreCompare(int[] arr){
			if(arr[0] == arr[1] && arr[1] == arr[2]){
				Console.WriteLine("EQUILATERAL");
			} else if(arr[0] == arr[1] || arr[1] == arr[2] || arr[0] == arr[2]){
				Console.WriteLine("ISOSCELES");
			} else{
				Console.WriteLine("SCALENE");
			}
		}
		
		static double CalcAverage(string[] arr){
			double avg = 0;
			double sum = 0;
			foreach(string n in arr){
				sum+=Convert.ToDouble(n);
			}
			avg = Math.Round(sum/arr.Length, 3);
			return avg;
		}
    }
}
