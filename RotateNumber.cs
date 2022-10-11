// See https://aka.ms/new-console-template for more information
using System;

namespace LearnDSAAlgorithm // Note: actual namespace depends on the project name.
{
    internal class RotateNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter a Number");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter a rotation Number");
            int k = int.Parse(Console.ReadLine());

            int temp = n;
            int nod = 0;
            while(temp>0)
            {
                temp = temp / 10;
                nod++;
            }
            k = k % nod;
            if(k<0)
            {
                k = k + nod;
            }
            int div = 1;
            int mul = 1;
            for(int i = 1; i <=nod; i++)
            {
                if(i<=k)
                {
                    div = div * 10;
                }
                else
                {
                    mul = mul * 10;
                }
            }
            int q = n / div;
            int r = n % div;

            int rot = r * mul + q;
            Console.WriteLine(rot);
        }
    }
}