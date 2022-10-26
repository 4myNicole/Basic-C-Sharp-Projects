using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
        static void Main(string[] args)
	{

        //Part 1 
        
        string[] titlesArray = { "Sir ", "Lady ", "Lord ", "Madam ", "Mr ", "Mrs "};
		Console.WriteLine("Please enter your name: ");
		string userName = Console.ReadLine();
		
		for (int i = 0; i <  titlesArray.Length; i++)
		{
		Console.WriteLine(titlesArray[i] + userName);
		}
		
		for (int j = 0; j < titlesArray.Length; j++)
		{
		Console.WriteLine(titlesArray[j]);
		}

        Console.WriteLine(" ");

        //Part 2

        //Infinate loop 
        //for (int p = 6; p == titlesArray.Length;)
		//{		Console.WriteLine(titlesArray.Length);		}

        for (int p = 6; p == titlesArray.Length; p++)
		{
		Console.WriteLine(titlesArray.Length);
		}

        Console.WriteLine(" ");

        
        for (int t = 2; t < titlesArray.Length; t--)
		{
			Console.WriteLine(titlesArray[t]);		
		}

        Console.WriteLine(" ");

        for (int r = 0; r <= titlesArray.Length; r++)
		{
			if (titlesArray[r] == "Lady ")
			{
				Console.WriteLine(titlesArray[r]);
		}
		
		}

        Console.WriteLine(" ");
        

        //Part 4
        // A list of strings where each item in the list is unique.
        // Ask the user to input text to search for in the list.
        // A loop that iterates through the list and then displays the index of the list that contains matching text on the screen.
        // Add code to the loop that tells a user if they put in text that isn’t in the list.
        // Add code to the loop that stops it from executing once a match has been found.
        

        



        //Part 5
        // A list of strings that has at least two identical strings in the list. Ask the user to select text to search for in the list.
        // Create a loop that iterates through the list and then displays the indices of the list that contain matching text on the screen.
        // Add code to the loop that tells a user if they put in text that isn’t in the list.
        



        //Part 6
        // Create a list of strings that has at least two identical strings in the list.
        // Create a foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list.
        

        

		

	}
}