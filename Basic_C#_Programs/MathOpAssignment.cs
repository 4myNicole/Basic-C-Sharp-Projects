using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
        static void Main(string[] args)
	{

	
		Console.WriteLine("What is your favourite number?");
		int yourNumber = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine(yourNumber + " times 50 is " + yourNumber * 50);

        Console.WriteLine("How old are you?");
		int yourAge = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("In 25 years you will be: " + yourAge + 25);

        Console.WriteLine("What day of the month were you born on?");
		int yourBirthDAY = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine(yourBirthDAY + "divided by 12.5 is " + yourBirthDAY / 12.5);

        Console.WriteLine("Pick a number and ill tell you if its more than 50");
		int pickANumber = Convert.ToInt32(Console.ReadLine());
        bool GreaterThanFifty = pickANumber > 50;
		Console.WriteLine(GreaterThanFifty);

        Console.WriteLine("What year were you born?");
		int birthYEAR = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine(birthYEAR + "divided by 7 has a remainder of " + birthYEAR % 7);
	}
}