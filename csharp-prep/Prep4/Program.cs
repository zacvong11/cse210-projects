using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int numberEntry;


        do
        {
           Console.Write("Enter a list of numbers, type '0' to finish: ");
           string input = Console.ReadLine();
           numberEntry = int.Parse(input);

           if (numberEntry != 0)
           {
            numbers.Add(numberEntry);
           }
        }while (numberEntry != 0);

        int sum = 0;
        foreach (int num in numbers)
        {sum += num;}

        float avg = ((float)sum) / numbers.Count;

        int max = numbers[0];
        foreach (int num in numbers)
        {if (num > max)
            {max = num;}
            }

        Console.WriteLine($"The sum is {sum}.");
        Console.WriteLine($"The average is {avg}.");
        Console.WriteLine($"The max is {max}.");

    //     foreach (int num in numbers)
    //     {Console.WriteLine(num);}
    }
}