Console.WriteLine("Hello, World!");
int low,high;
Console.WriteLine("Please enter the Start Number");
low = int.Parse(Console.ReadLine());
high = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter the End Number");
for (int a = low; a <=high; a++)
{
    int count=0;
    for (int div = 2; div*div<=a; div++)
    {
        if (a%div==0)
        {
            count++;
            break;
        }
    }
    if (count == 0)
    {
        Console.WriteLine(a);
    }
}