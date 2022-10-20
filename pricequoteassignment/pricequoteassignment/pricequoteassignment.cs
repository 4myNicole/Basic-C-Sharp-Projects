using System;

namespace pricequoteassignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Please enter package weight:");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("Please enter package width:");
            }
            int packageWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter package height:");
            int packageHeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter package length:");
            int packageLength = Convert.ToInt32(Console.ReadLine());

            if (packageWidth + packageHeight + packageLength > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }

            decimal totalCost = (((packageHeight * packageLength * packageLength) * packageWeight) / 100);
            Console.WriteLine("Your estimated total for shipping this package is: \u00A3" + totalCost);
        }
    }
}
