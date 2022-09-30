// See https://aka.ms/new-console-template for more information
using System;

namespace LearnDSAAlgorithm // Note: actual namespace depends on the project name.
{
    internal class InverseNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter a Number");
            int n = int.Parse(Console.ReadLine());

            int inv = 0;
            int op = 1;
            while(n!=0)
            {
                int od = n % 10;
                int id = op;
                int ip = od;

                //make change to inv using ip and id
                inv = inv + id * ((int)Math.Pow(10, ip - 1));
                n = n / 10;
                op++;
            }
            Console.Write(inv);

        }
    }
}