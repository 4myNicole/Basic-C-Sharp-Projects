using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
        static void Main(string[] args)
	{
        
        try
		{
		Console.WriteLine("Pick a number");
		int numberOne = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Pick another number");
		int numberTwo = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Dividing the two...");
		int numberThree = numberOne / numberTwo;
		
		Console.WriteLine(numberOne + " divided by " + numberTwo + " = " + numberThree);
		}
		catch (FormatException ex)
		{
			Console.WriteLine("Please type a whole number");
			return;
		}
		catch (DivideByZeroException ex)
		{
			Console.WriteLine("Please dont divide by 0");
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
		finally
		{
			Console.ReadLine(); 
	    }
	}
}