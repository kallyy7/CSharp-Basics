using System;

public class Fishland
{
    public static void Main()
    {
        double mackerelPrice = double.Parse(Console.ReadLine());
        double spratPrice = double.Parse(Console.ReadLine());
        double bonitoKg = double.Parse(Console.ReadLine());
        double horseMackerelKg = double.Parse(Console.ReadLine());
        double mussel = double.Parse(Console.ReadLine());

        double bonitoPrice = mackerelPrice + (mackerelPrice * 0.60);
        double bonitoAmount = bonitoKg * bonitoPrice;
        double horseMackerelPrice = spratPrice + (spratPrice * 0.80);
        double hourseMackerelAmount = horseMackerelKg * horseMackerelPrice;
        double musselAmount = mussel * 7.50;
        double allAmount = bonitoAmount + hourseMackerelAmount + musselAmount;

        Console.WriteLine($"{allAmount:F2}");
    }
}
