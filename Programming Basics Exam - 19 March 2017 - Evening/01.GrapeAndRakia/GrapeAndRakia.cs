using System;

public class GrapeAndRakia
{
    public static void Main()
    {
        double areaOfTheVineyard = double.Parse(Console.ReadLine());
        double kg = double.Parse(Console.ReadLine());
        double waste = double.Parse(Console.ReadLine());

        double grapeKg = (areaOfTheVineyard * kg) - waste;
        double forRakia = grapeKg * 45 / 100;
        double rakiaLeters = forRakia / 7.5;
        double rakiaBGN = rakiaLeters * 9.80;
        double forSell = grapeKg * 55 / 100;
        double income = forSell * 1.50;

        Console.WriteLine($"{rakiaBGN:F2}");
        Console.WriteLine($"{income:F2}");
    }
}