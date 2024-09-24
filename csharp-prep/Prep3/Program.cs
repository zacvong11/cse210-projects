using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,100);
       
        int guess;

        do
        {
            Console.Write("The magic number has been selected. What is your guess? ");
            string guessedNumber = Console.ReadLine();
            guess = int.Parse(guessedNumber);
        

            if (guess > number)
                {Console.WriteLine("Lower");}
            else if (guess < number)
                 {Console.WriteLine("Higher");}
             else
                 {Console.WriteLine("You guessed it!");}

        } while (guess != number);


    }
}