using System;

public class Bakery
{
    public static void Main()
    {
        double weightDough = double.Parse(Console.ReadLine());
        double weightBakery = double.Parse(Console.ReadLine());
        double bakeryPrice = double.Parse(Console.ReadLine());
        double soldBakery = double.Parse(Console.ReadLine());
        double soldSweets = double.Parse(Console.ReadLine());

        double dayIncome = soldBakery * bakeryPrice;
        double dough = soldBakery * weightBakery;
        double doughtSweets = (weightDough - dough) + dough;
        double sweetsPrice = bakeryPrice + (bakeryPrice * 0.25);
        double weghtSweets = weightBakery * 0.80;
        double doughUsedForSweets = soldSweets * weghtSweets;
        double nightIncome = soldSweets * sweetsPrice;
        double outcome = ((weightDough - (weightDough - dough) + doughtSweets) / 1000) * 4;
        double salary = (dayIncome + nightIncome) - outcome;
        double usedDough = Math.Round(dough + doughUsedForSweets);

        Console.WriteLine($"Pure income: {salary:F2} lv.");
        Console.WriteLine($"Dough used: {usedDough} g.");
    }
}