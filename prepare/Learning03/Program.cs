using System;
using System.Security.Cryptography.X509Certificates;

class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    public int GetTop()
    {
        return _top;
    }
    public void SetTop(int top)
    {
        _top = top;
    }
    public int GetBottom()
    {
        return _bottom;
    }
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string text = $"{_top} / {_bottom}";
        return text;
    }
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }



    static void Main(string[] args)
    {
    Fraction f1 = new Fraction();
    Fraction f2 = new Fraction(5);
    Fraction f3 = new Fraction(1, 3);

    Console.WriteLine(f1.GetFractionString());
    Console.WriteLine(f2.GetFractionString());
    Console.WriteLine(f3.GetFractionString());
    
    Console.WriteLine(f1.GetDecimalValue());
    Console.WriteLine(f2.GetDecimalValue());    
    Console.WriteLine(f3.GetDecimalValue());

    }


}
