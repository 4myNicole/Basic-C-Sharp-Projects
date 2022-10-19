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
		

        string name = "Jesse";
        string quote = "The man said, \"Hello\", Jesse.";
        string fileName = @"C:\Users\Jesse"; 

        bool trueOrFalse = name.Contains("s");
        trueOrFalse = name.EndsWith("s");

        int length = name.Length;

        name = name.ToUpper();

        Console.WriteLine(quote);
        Console.WriteLine(trueOrFalse);
        Console.WriteLine(length);
        Console.WriteLine(name);
        Console.ReadLine();

        string name = "Jesse";
        name = "Joe";

        Console.WriteLine(name);
        Console.ReadLine();

        //output Joe

        StringBuilder sb = new StringBuilder();

        sb.Append("My name is Jesse");
         Console.WriteLine(sb);



	}
 }
}