using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction defaultFraction = new Fraction();
        Console.WriteLine("Fraction String : {0}",defaultFraction.GetFractionString());
        Console.WriteLine("Get Decimal value: {0}", defaultFraction.GetDecimalValue());

        Fraction wholeFraction = new Fraction(5);
        Console.WriteLine("Fraction String : {0}",wholeFraction.GetFractionString());
        Console.WriteLine("Get Decimal value: {0}", wholeFraction.GetDecimalValue());

        Fraction decimalFraction = new Fraction(3,4);
        Console.WriteLine("Fraction String : {0}",decimalFraction.GetFractionString());
        Console.WriteLine("Get Decimal value: {0}", decimalFraction.GetDecimalValue());

        //Getters
        Console.WriteLine("Using Getters after Setters");
        Console.WriteLine("Using Getter\nGetTop: {0}",decimalFraction.GetTop());
        Console.WriteLine("Using Getter\nGetBottom: {0}",decimalFraction.GetBottom());
        //Setters
        Console.WriteLine("Using Getters after Setters");
        decimalFraction.SetTop(2);
        decimalFraction.SetBottom(3);
        Console.WriteLine("Using Getter\nGetTop: {0}",decimalFraction.GetTop());
        Console.WriteLine("Using Getter\nGetBottom: {0}",decimalFraction.GetBottom());
        //Getting the fraction string and decimal values after using Getters and Setters
        Console.WriteLine("Fraction String : {0}",decimalFraction.GetFractionString());
        Console.WriteLine("Get Decimal value: {0}", decimalFraction.GetDecimalValue());
    }
}