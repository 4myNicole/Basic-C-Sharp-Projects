using System;

namespace stringassignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Cstring one = "Hello! ";
            string two = "My name is Amy. ";
            string three = "Nice to meet you.";
            string greeting = (one + two + three);

            one = one.ToUpper();
            Console.WriteLine(greeting);
            Console.WriteLine(one);

            StringBuilder sb = new StringBuilder();

            sb.Append("Hola ");
            sb.Append("Me llamo Amy, ");
            sb.Append("Mucho Gusto!");

            Console.WriteLine(sb);
        }
    }
}
