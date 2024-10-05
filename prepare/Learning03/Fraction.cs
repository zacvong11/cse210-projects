class Fraction
{
    private double _numerator;
    private double _denomonator;
    private double _decimal;

    public double Numerator
    {
        get { return _numerator; }

        set{
            _numerator = value;
            UpdateDecimal();
        }
    }

    public double Denomonator
    {
        get {return _denomonator;}

        set {
            _denomonator = value;
            UpdateDecimal();
        }
    }


    public double DecimalValue
    {
        get {return _decimal;}
    }

    private void UpdateDecimal()
    {
        _decimal = _numerator / _denomonator;
    }

    
    public Fraction()
    {
        _numerator = 1;
        _denomonator = 1;

        Console.WriteLine("\nThe default fraction is " + _numerator + "/" + _denomonator + ".\n");
    }

    public Fraction(double argNumberator)
    {
        _numerator = argNumberator;
        _denomonator = 1;
        _decimal = argNumberator / _denomonator;

        Console.WriteLine("Your fraction is " + _numerator + "/" + _denomonator + ". The decimal is " + _decimal + ".");
    }
    
    
    public Fraction(double argNumerator, double argDenomonator)
    {
        _numerator = argNumerator;
        _denomonator = argDenomonator;
        _decimal = argNumerator / argDenomonator;

        Console.WriteLine("\nYour fraction is " + _numerator + "/" + _denomonator + ". The decimal is " + _decimal + ".");
    }

    public override string ToString()
    {
        return $"Your new fracion is {_numerator} / {_denomonator}. The updated decimal is {_decimal}.";
    }
}