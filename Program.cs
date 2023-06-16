using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj podstawę: ");
        double baseNumber = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Podaj wykładnik: ");
        int exponent = Convert.ToInt32(Console.ReadLine());

        double result = Power(baseNumber, exponent);
        Console.WriteLine($"{baseNumber}^{exponent} = {result}");
    }

    static double Power(double baseNumber, int exponent)
    {
        double result = 1.0;
        for (int i = 0; i < exponent; i++)
        {
            result *= baseNumber;
        }
        return result;
    }
}