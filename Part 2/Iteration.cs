using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
        static void Main(string[] args)
	{
        //integer array
        int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };
		
		for (int i = 0; i < testScores.Length; i++)
		{
			if (testScores[i] > 85)
			{
				Console.WriteLine("Passing test score: " + testScores[i]);
		}
    }
		

        //string array 

        string[] names = { "Jesse", "Erik", "Daniel", "Adam" };
		
		for (int j = 0; j < names.Length; j++)
		{
			if (names[j] == "Jesse")
			{
				Console.WriteLine(names[j]);
		}
		
		}
      		


         // integer list
		List<int> testScores = new List<int>();
		testScores.Add(98);
		testScores.Add(99);
		testScores.Add(81);
		testScores.Add(72);
		testScores.Add(70);
		
		foreach (int score in testScores)
		{
		  if (score > 85)
		  {
		   Console.WriteLine("Passing test score: " + score);
		  }
		}
		

        //string list
		
		List<string> names = new List<string> { "Jesse", "Erik", "Daniel", "Adam" };
		
		foreach (string name in names)
		{
		 if (name == "Jesse")
		 {
		 Console.WriteLine(name);
		 }
		}

        // integer list, add ints with certian parameters to another list

        List<int> testScores = new List<int>() { 98, 99, 85, 70, 82, 34, 91, 90, 94 };
		List<int> passingScores = new List<int>();
		
		foreach (int score in testScores)
		{
			if (score > 85)
			{
			passingScores.Add(score);
			
			}
		}
		
		Console.WriteLine(passingScores.Count);
		Console.ReadLine();
	}
}