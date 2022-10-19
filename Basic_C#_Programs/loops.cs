using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
        static void Main(string[] args)
	{

        Console.WriteLine("Guess a number?:");
        int number = Convert.ToInt32(Console.ReadLine());
        bool isGuessed = number == 12;

        do
        {
            switch (number)
        {
            case 62: 
                Console.WriteLine("you guessed 62. Try again");
                Console.WriteLine("Guess a number?");
                number = Convert.ToInt32(Console.ReadLine());
                break;
            case 29: 
                Console.WriteLine("you guessed 29. Try again");
                Console.WriteLine("Guess a number?");
                number = Convert.ToInt32(Console.ReadLine());
                break;
            case 55: 
                Console.WriteLine("you guessed 55. Try again");
                Console.WriteLine("Guess a number?");
                number = Convert.ToInt32(Console.ReadLine());
                break;
            case 12: 
                Console.WriteLine("you guessed 12. that is correct!");
                break;
              default:
                Console.WriteLine("You are wrong");
                Console.WriteLine("Guess a number?");
                number = Convert.ToInt32(Console.ReadLine());
                break;
                }

        }	 
 while (!isGuessed); 
        Console.Read(); 

	}
}