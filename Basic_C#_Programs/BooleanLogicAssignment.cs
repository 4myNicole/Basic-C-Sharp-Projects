using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
        static void Main(string[] args)
	{

        Console.WriteLine("What is your age?");
        int yourAge = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Have you ever had a DUI violation?");
        string duiViolation = Console.ReadLine();
        bool yesOrNo = duiViolation == "yes";
        Console.WriteLine(yesOrNo);

        Console.WriteLine("How many speeding tickets have you had?");
        int speedingTickets = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Qualified?");
        bool qualified = (yourAge > 15 && duiViolation == false && speedingTickets <= 3);

    	}
}
