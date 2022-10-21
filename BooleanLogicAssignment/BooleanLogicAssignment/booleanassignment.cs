using System;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int yourAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI violation? (please answer true or false)");
            bool duiViolation = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets have you had?");
            int speedingTickets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qualified?");
            bool qualified = Console.WriteLine(yourAge > 15 && duiViolation == false && speedingTickets <= 3);
        }
    }
}
