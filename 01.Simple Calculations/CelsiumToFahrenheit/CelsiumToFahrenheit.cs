using System;

class CelsiumToFahrenheit
{
    public static void Main()
    {
        double C = double.Parse(Console.ReadLine());
        double F = C * 1.8 + 32;

        Console.WriteLine(Math.Round(F, 2));
    }
}
