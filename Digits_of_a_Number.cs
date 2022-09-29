// See https://aka.ms/new-console-template for more information
using System;

namespace LearnDSAAlgorithm // Note: actual namespace depends on the project name.
{
    internal class Digits_of_a_Number
    {
       
        static void Main(string[] args)
        {
            int digit = 0;
            Console.WriteLine("Please Enter a Numebr");
            int temp = int.Parse(Console.ReadLine());
            int b = temp;
            while (b != 0)
            {
                b = b / 10;
                digit++;
            }
            int div = (int)Math.Pow(10, digit - 1);
            while(div!=0)
            {
                int a = temp / div;
                Console.WriteLine(a);
                temp = temp % div;
                div = div / 10;
            }
            //if we put while(temp!=0) then zero will not come out.we make the remaider zero
        }
    }
}