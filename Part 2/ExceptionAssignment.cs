using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
        static void Main(string[] args)
	{
        
        Start:
		try {
		List<int> intList = new List<int>();
		intList.Add(4);
		intList.Add(10);
        intList.Add(49);
        intList.Add(4875);
        intList.Add(826);
		
		Console.WriteLine("Please input a whole number:");
        int userNumber = Convert.ToInt32(Console.ReadLine());
		
		foreach (int num in intList)
		{
			Console.WriteLine(num + " divided by " + userNumber + " equals " + num / userNumber);
		}
		}
		catch (DivideByZeroException ex)
		{
			Console.WriteLine("Please dont divide by 0");
			goto Start;
		}
		catch (Exception)
			{
				goto Start;
			}
		
		Console.WriteLine("\nYou are now out of the try/catch block");


        
	}
}