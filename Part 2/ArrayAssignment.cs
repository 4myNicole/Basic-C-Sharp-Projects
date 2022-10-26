using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
        static void Main(string[] args)
	{

        // number 1

		string[] animalArray = { "Baboon", "Snake", "Elephant", "Iguana", "Turtle", "Shark"};

        Console.WriteLine("Pick a number between 0 and 5 and ill tell you what your spirit animal is: ");    
		int userAnimal = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine(animalArray[userAnimal]);



        //number 2 & 3

		int[] luckyNumbers = { 21, 69, 40, 420, 9000, 43534, 23498, 23432, 9547838, 123749, 54837};

        Console.WriteLine("Pick a number between 0 and 10 and ill tell you what your lucky number is ");
		int yourLuckyNum = Convert.ToInt32(Console.ReadLine());
	
		if (yourLuckyNum >10 || yourLuckyNum <0)
		{
			Console.WriteLine("Please select a number between 0 and 10");
		}
		else
		
		Console.WriteLine(luckyNumbers[yourLuckyNum]);



        //number 4 
		List<string> stringList = new List<string> { "Portugal", "Canada", "Iceland", "New Zealand", "Japan", "Mexico" };

        Console.WriteLine("Select a number from 0 to 5 and ill tell you which country to visit next:");
		int yourDestination = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine(stringList[yourDestination]);

		

	}
}