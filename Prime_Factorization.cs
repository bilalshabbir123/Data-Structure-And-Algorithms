// See https://aka.ms/new-console-template for more information
using System;

namespace LearnDSAAlgorithm // Note: actual namespace depends on the project name.
{
    internal class Prime_Factorization
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter a Number");
            int n = int.Parse(Console.ReadLine());
            for (int div = 2; div*div < n; div++)
            {
                while(n%div==0)
                {
                    n = n / div;
                    Console.Write(div + " ");
                }
            }
           if(n !=1)
            {
                Console.Write(n);
            }
        }
    }
}