using System;

class Program
{
        static void Main()
	{
		Console.WriteLine("Pitman Training \n Student Daily Report");
		Console.ReadLine();

        Console.WriteLine("What course are you in?");
		string whatCourse = Console.ReadLine();

        Console.WriteLine("What page number?");
		int whatPage = Console.ReadLine();

        Console.WriteLine("Do you need help with anything?  Please answer \"true\" or \"false\".");
		bool needHelp = Console.ReadLine();

        Console.WriteLine("Were there any positive experiences you\'d like to share?  Please provide specifics.");
		string posExperience = Console.ReadLine();

        Console.WriteLine("Is there any other feedback you\'d like to provide?  Please be specific.");
		string anyFeedback = Console.ReadLine();

        Console.WriteLine("How many hours did you study today?");
		double whatPage = Console.ReadLine();

        Console.WriteLine("Thank you for your responses.  An Instructor will respond shortly.  Have a great day!");
		Console.ReadLine();

	}
}