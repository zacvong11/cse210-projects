using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();
        string name = GetUsername();
        int number = GetUserNumber();
        int numberSquared = SquareNumber(number);
        // Console.WriteLine($"Hello {name}!");
        Console.WriteLine($"{name}, your favorite number squared is {numberSquared}.");
    }

    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string GetUsername()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int GetUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string numberEntered = Console.ReadLine();

        int number = int.Parse(numberEntered);

        return number;
    }

    static int SquareNumber(int number)
    {
        int numberSquared = number * number; 

        return numberSquared;
    }

    
}