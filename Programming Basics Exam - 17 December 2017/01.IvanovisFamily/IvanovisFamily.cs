using System;

public class IvanovisFamily
{
    public static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        double firstChild = double.Parse(Console.ReadLine());
        double secondChild = double.Parse(Console.ReadLine());
        double thirdChild = double.Parse(Console.ReadLine());

        double amount = firstChild + secondChild + thirdChild;
        double budgetLeft = (budget - amount);
        double dds = budgetLeft * 0.1;
        double donation = budgetLeft - dds;

        Console.WriteLine($"{donation:F2}");
    }
}
