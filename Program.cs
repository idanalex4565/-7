using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
			int PrimeNumber;
			do
			{
				Console.Write("Please enter number (Prime checking) :");
				PrimeNumber = Convert.ToInt32(Console.ReadLine());
				PrimeCheck(PrimeNumber);
			}
			while (!PrimeCheck(PrimeNumber));
			Console.WriteLine("Its a Prime!!");
			Console.ReadLine();
			-------------------
			int num, i=1;
			do
			{
				if (i < 5)
				{
					Console.Write("Enter 2 digets number: ");
					num = Convert.ToInt32(Console.ReadLine());
					i++;
				}
				else
				{
					Console.Write("I told you to enter 2 digets number!: ");
					num = Convert.ToInt32(Console.ReadLine());
					i++;
				}
			}
			while (CheckingIf2DigitNumber(num)) ;

			if (i < 3) 
			{
				Console.WriteLine("Great you have entered a 2 digit numbet!");
			}
			else
			{
				Console.WriteLine("Finaly you have entered a 2 digit number");
			}
			Console.WriteLine($"is {num} is a 2 digit number? {!CheckingIf2DigitNumber(num)}");
			Console.ReadLine();
			*/
			int a, b, c;
			Console.WriteLine("Please enter 3 numbers between 1 and 1000");
			a = Between1And1000();
			b = Between1And1000();
			c = Between1And1000();
			if (CheckingIfBiggerThen15(a) && CheckingIfBiggerThen15(b) && CheckingIfBiggerThen15(c))
			{
				Console.WriteLine($"The sum of the 3 numbers is: {a + b + c}");
			}
			else
			{
				Console.WriteLine("not bigger then 15");
			}
			Console.ReadLine();
		}

		private static int Between1And1000()
		{
			int a;
			do
			{
				Console.Write("Please enter a numbers: ");
				a = Convert.ToInt32(Console.ReadLine());
			}
			while (a < 0 || a > 1000);
			return a;
		}

		private static bool CheckingIfBiggerThen15(int a)
		{
			int sum = 0;
			do
			{
				sum = sum + (a % 10);
				a = a / 10;
			}
			while (a > 0);
			if (sum > 15)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		private static bool PrimeCheck(int PrimeNumber)
		{
			int m = 2;
			while (PrimeNumber % m != 0)
			{
				m++;
			}

			if (m < PrimeNumber)
			{
				return false;
			}
			else
			{
				return true;
			}			
		}
		

		private static bool CheckingIf2DigitNumber(int num)
		{
			if (num > 9 && num < 100) 
			{
				return false;
			}
			else
			{
				return true;
			}
		}
	}
}
