// See https://aka.ms/new-console-template for more information
/*if the Prime number is that which is only divisible by one and itself.we start the dividing from zero because every number is divible by one.
if count increament then show it a not a prime number*/

int a;

Console.WriteLine("How many Numbers you want to Check the it's Prime or not");
a=int.Parse(Console.ReadLine());
for (int i = 0; i < a; i++)
{
    //Console.WriteLine("Enter a Number To Check Prime or ");
    int b=int.Parse(Console.ReadLine());
    int count = 0;
    
    for (int div = 2; div*div <= b; div++)
    {
        if (b%div==0)
        {
            count++;
            break;
        }
    }
    if (count==0)
    {
        Console.WriteLine("Prime\n");
    }
    else
    {
        Console.WriteLine("Not Prime\n");
    }
}
