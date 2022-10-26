using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
        static void Main(string[] args)
	{

        // Arrays -- used for fixed quantities.
		
     int[] numArray = new int[5];
	    numArray[0] = 5;
		numArray[1] = 2;
        numArray[2] = 10;
        numArray[3] = 200;
        numArray[4] = 5000;

        
        		
		int[] numArray1 = new int[] { 5, 2, 10, 200, 5000}; //easier way of adding array

        int[] numArray2 = { 5, 2, 10, 200, 5000}; //even faster and easier

        numArray2[4] = 650;
		
		Console.WriteLine(numArray[3]);
        Console.WriteLine(numArray1[3]);
        Console.WriteLine(numArray2[3]);
        Console.WriteLine(numArray2[4]);
        Console.ReadLine();
		
        byte[] byteArray = new byte[5000]; //for large things


		//end of arrays
		
		//lists 
		
        //integer list
		List<int> intList = new List<int>();
		intList.Add(4);
		intList.Add(10);
		intList.Remove(10);
		
		Console.WriteLine(intList[0]);
		
		//string list
		List<string> intString = new List<string>();
		intString.Add("Amy");
		intString.Add("Nicole");
		
		
		Console.WriteLine(intString[0]);
		Console.ReadLine();
		
		
		//end of lists
		

	}
}
