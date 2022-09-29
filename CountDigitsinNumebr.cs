// See https://aka.ms/new-console-template for more information
using System;

namespace LearnDSAAlgorithm // Note: actual namespace depends on the project name.
{
    internal class CountDigitsinNumebr
    {
       
        static void Main(string[] args)
        {
            int digit = 0;
            Console.WriteLine("Please Enter a Digit");
            int a = int.Parse(Console.ReadLine());
            while (a!=0)
            {
                a = a / 10;
                digit++;
            }
            Console.WriteLine(digit);

        }
    }
}