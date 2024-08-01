```C#
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Number of trailing zeroes in " + number + "! is " + FindTrailingZeros(number));
    }

    static int FindTrailingZeros(int number)
    {
        int count = 0;
        for (int i = 5; number / i >= 1; i *= 5)
            count += number / i;
        return count;
    }
}
```