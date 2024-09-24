using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade as a percentage? ");
        string grade_prcntg = Console.ReadLine();

        int grade = int.Parse(grade_prcntg);

        if (grade >= 90)
            {Console.WriteLine("Your got an A. Great job!");}
        else if (grade >= 80)
            {Console.WriteLine("You got a B, that's pretty good!");}
        else if (grade >= 70)
            {Console.WriteLine("You got a C, you passed!");}
        else if (grade >= 60)
            {Console.WriteLine("You got a D, try a harder next time.");}
        else
            {Console.WriteLine("You failed...");}


    }
}