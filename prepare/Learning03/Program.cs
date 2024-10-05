using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fractionDefault = new Fraction();

        Fraction fractionNumerator = new Fraction(3);


        // arg 1 numerator, arg 2 denomonator
         Fraction fraction1 = new Fraction(1, 2);
         Fraction fraction2 = new Fraction(4,5);
        // fraction1._numerator = 1;
        // fraction1._denomonator = 2;
        // fraction1._decimal = fraction1._numerator / fraction1._denomonator;

        // Console.WriteLine("\nYour fraction is " + fraction1._numerator + "/" + fraction1._denomonator + ". The decimal is " + fraction1._decimal + ".");

        fraction2.Numerator = 5;
        fraction2.Denomonator = 20;

        Console.WriteLine(fraction2);
    }
}



