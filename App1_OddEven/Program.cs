using System;

namespace App1_OddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.Write("\t\tEnter a number : ");
            long n = long.Parse(Console.ReadLine());

            if(n % 2 == 0)
            {
                Console.WriteLine("\t\t-> Even number");
            }
            else
            {
                Console.WriteLine("\t\t-> Odd number\n");
            }
        }
    }
}
