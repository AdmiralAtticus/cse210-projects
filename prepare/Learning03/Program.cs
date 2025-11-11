using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f = new Fraction(3, 4);

        Console.WriteLine(f.GetFractionString());

        f.SetTop(5);
        f.SetBottom(6);

        Console.WriteLine(f.GetFractionString());
        Console.WriteLine(f.GetDecimalValue());
        
    }
}