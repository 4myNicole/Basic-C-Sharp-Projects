using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
        static void Main(string[] args)
	{

        int currentTemp = 70;
        int roomTemp = 70;

        if (currentTemp == roomTemp)
        {
            Console.WriteLine("It is exactly room temperature");
        }
        else if (currentTemp > roomTemp)
        {
            Console.WriteLine("It is warmer than room temperature");
        }
        else if (currentTemp < roomTemp)
        {
            Console.WriteLine("It is cooler than room temperature");
        }
        else
        {
            Console.WriteLine("It is not exactly room temperature.");
        }
        Console.ReadLine();

        string comparisonResult = currentTemp == roomTemp ? "It is room temp" : "it is not room temp"; //ternary operator

        


	}
}