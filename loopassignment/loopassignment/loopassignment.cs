using System;

namespace loopassignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 50;
            while (i <= 100)
            {
                Console.WriteLine(i);
                i++;
            }


            int j = 99;
            do
            {
                Console.WriteLine(j);
                j--;
            }

            while (j >= 50);
        }
    }
}
