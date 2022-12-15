using System;

namespace Perfect_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

Console.WriteLine("Enter the start number...");
int srt = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the end number...");
int end = int.Parse(Console.ReadLine());

for (int i = srt; end >= i; i++)
{
    int sum = 0;
    int n = 1;

    while (i > n)
    {
        if (i % n == 0)

            sum += n;
        n++;
    }

    if (i == sum)
        Console.WriteLine("{0}", i);
}
        }
    }
}
