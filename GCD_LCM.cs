// See https://aka.ms/new-console-template for more information
using System;

namespace LearnDSAAlgorithm // Note: actual namespace depends on the project name.
{
    internal class RotateNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter a Number");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter a Second Number");
            int n2 = int.Parse(Console.ReadLine());

            int on1 = n1;
            int on2 = n2;
            while(n1%n2!=0)
            {
                int rem = n1 % n2;
                n1 = n2;
                n2 = rem;
            }
            int gcd = n2;
            int lcm = (on1 * on2) / gcd;
            Console.WriteLine("GCD :"+gcd);
            Console.WriteLine("LCM :"+lcm);
           
        }
    }
}