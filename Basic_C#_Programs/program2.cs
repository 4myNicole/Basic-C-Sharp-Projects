using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
	


class Program
 {
        static void Main(string[] args)
	{
		This is a simple program
		Console.WriteLine("What is your name?");
		string yourName = Console.ReadLine();
		Console.WriteLine("Your name is: " + yourName);
		Console.ReadLine();

		Console.WriteLine("What is your favourite number?");
		string favouriteNumber = Console.ReadLine();
		int favNum = Convert.ToInt32(favouriteNumber);
		int total = favNum + 5;
		Console.WriteLine("Your favourite number plus 5 is: " + total);
		Console.ReadLine();

		bool isStudying = false;
		byte hoursWorked = 42;
		sbyte currentTemp = -23;
		char questionMark = '\u2103';

		decimal moneyInBank = 100.5m;
		double heightInCM = 211.3020392;
		float secondsLeft = 2.62f;
		short temperatureOnMars = -341;
		string myName = "Jesse";

		int currentAge = 30;
		string yearsOld = currentAge.ToString();

		bool isRaining = true;
		string rainingStatus = Convert.ToString(isRaining);



	}
 }
}