using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
        static void Main(string[] args)
	{

        Console.WriteLine("Anonymous Income Comparison Program");

        Console.WriteLine("Hello Person 1");

        Console.WriteLine("What is your hourly rate?");
        decimal hourlyRateP1 = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("How many hours do you work a week?");
        decimal weeklyHoursP1 =  Convert.ToDecimal(Console.ReadLine());

         Console.WriteLine("Hello Person 2");

        Console.WriteLine("What is your hourly rate?");
        decimal hourlyRateP2 =  Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("How many hours do you work a week?");
        decimal weeklyHoursP2 =  Convert.ToDecimal(Console.ReadLine());

        decimal p1AnnualSalary = (hourlyRateP1 * weeklyHoursP1) * 52;
        decimal p2AnnualSalary = (hourlyRateP2 * weeklyHoursP2) * 52;
        Console.WriteLine("Person 1\'s annual salary: \n" + p1AnnualSalary);
        Console.WriteLine("Person 2\'s annual salary: \n" + p2AnnualSalary);

        Console.WriteLine("Person 1 makes more money than person 2");
        bool GreaterThanPerson1 = p1AnnualSalary > p2AnnualSalary;
		Console.WriteLine(GreaterThanPerson1);
						  

	}
}