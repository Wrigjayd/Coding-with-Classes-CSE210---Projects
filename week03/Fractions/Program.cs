using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        Fraction threeFourths = new Fraction();
        Console.WriteLine(threeFourths.GetFractionString(3, 4));
        Console.WriteLine(threeFourths.GetDecimalValue(3, 4));
        Console.WriteLine(threeFourths.GetFractionString());
        Console.WriteLine(threeFourths.GetDecimalValue());
        Console.WriteLine(threeFourths.GetFractionString(5));
        Console.WriteLine(threeFourths.GetDecimalValue(5));
        Console.WriteLine(threeFourths.GetFractionString(1, 3));
        Console.WriteLine(threeFourths.GetDecimalValue(1, 3));
    }
}