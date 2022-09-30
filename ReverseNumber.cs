// See https://aka.ms/new-console-template for more information
using System;

namespace LearnDSAAlgorithm // Note: actual namespace depends on the project name.
{
    internal class ReverseNumber
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a Numebr");
            int n = int.Parse(Console.ReadLine());
            while ( n> 0)
            {
               int digit = n % 10;
                Console.Write(digit);
                n = n / 10;

            }

        }
    }
}