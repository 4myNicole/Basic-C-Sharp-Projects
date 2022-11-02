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
        List<string> animalsList = new List<string>();
		animalsList.Add("cat");
		animalsList.Add("dog");
		animalsList.Add("hamster");
		animalsList.Add("lizard");
		
		Console.WriteLine("type either 'dog', 'cat', 'hamster' or 'lizard' and ill tell you where it is in my list: ");
		string userGuess = Console.ReadLine().ToLower();
		
		if (animalsList.Contains(userGuess))
		{		
		Console.WriteLine(userGuess + " is number " + animalsList.IndexOf(userGuess) + " in my list!");
		}
		else
		{
		Console.WriteLine(userGuess + " is not in my list!");
		}
		
		Console.WriteLine(" ");
		
		foreach (string animal in animalsList)
		{
		 if (animal == userGuess)
		 {
		 Console.WriteLine(animal);
		 }
		}
        
        //Part 5
        
        // Create a loop that iterates through the list and then displays the indices of the list that contain matching text on the screen.
        // ^^ Still cant get index of 2nd 'sweetcorn'
        
        
        List<string> pizzaToppings = new List<string>();
		pizzaToppings.Add("sweetcorn");
		pizzaToppings.Add("pepper");
		pizzaToppings.Add("broccoli");
		pizzaToppings.Add("mushroom");
		pizzaToppings.Add("spinach");
		pizzaToppings.Add("sweetcorn");
		
		Console.WriteLine("type one of the following toppings: 'sweetcorn', 'pepper', 'broccoli', 'mushroom', 'spinach' ");
		
		string userTopping = Console.ReadLine().ToLower();
		
		foreach (string topping in pizzaToppings)
		{
			if (topping == userTopping)
		{		
		Console.WriteLine(userTopping + " is number " + pizzaToppings.IndexOf(topping) + " in my list!");
		}
		else
		{
		Console.WriteLine(userTopping + " is NOT number " + pizzaToppings.IndexOf(topping) + " in my list!");
		}
		}
		

        Console.WriteLine(" ");

        //Part 6
        // Create a list of strings that has at least two identical strings in the list. DONE
        // Create a foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list.
        List<string> coloursList = new List<string>();
		coloursList.Add("blue");
		coloursList.Add("red");
		coloursList.Add("orange");
		coloursList.Add("red");
		coloursList.Add("yellow");
		coloursList.Add("green");
		
		List<string> newColoursList = new List<string>();
		
						
		foreach (string colour in coloursList) 
		{
			if (!newColoursList.Contains(colour));
		    newColoursList.Add(colour);
		}

		
		Console.WriteLine(newColoursList[0]);
		Console.WriteLine(newColoursList[1]);
		Console.WriteLine(newColoursList[2]);
		Console.WriteLine(newColoursList[3]);
		Console.WriteLine(newColoursList[4]);
		Console.WriteLine(newColoursList[5]);
        
    }
}