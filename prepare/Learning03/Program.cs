using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(5);
        Fraction f3 = new Fraction(3, 4);
        Fraction f4 = new Fraction(1, 3);
        Fraction f5 = new Fraction();
        f5.SetTop(3);
        f5.SetBottom(4);
        int top = f5.GetTop();
        int bottom = f5.GetBottom();
        Console.WriteLine($"{top}");
        Console.WriteLine($"{bottom}");

        Console.WriteLine($"{f1.GetFractionString()}");
        Console.WriteLine($"{f1.GetDecimalValue()}");
        Console.WriteLine($"{f2.GetFractionString()}");
        Console.WriteLine($"{f2.GetDecimalValue()}");
        Console.WriteLine($"{f3.GetFractionString()}");
        Console.WriteLine($"{f3.GetDecimalValue()}");
        Console.WriteLine($"{f4.GetFractionString()}");
        Console.WriteLine($"{f4.GetDecimalValue()}");
    }
}