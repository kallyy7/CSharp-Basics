using System;

public class CakeTycoon
{
    public static void Main()
    {
        decimal n = decimal.Parse(Console.ReadLine());
        decimal c = decimal.Parse(Console.ReadLine());
        decimal f = decimal.Parse(Console.ReadLine());
        decimal t = decimal.Parse(Console.ReadLine());
        decimal p = decimal.Parse(Console.ReadLine());

        decimal cakes = Math.Floor(f / c);
        decimal truffles = t * p;

        if (n <= cakes)
        {
            decimal price = (truffles / n) * 125 / 100;
            Console.WriteLine($"All products available, price of a cake: {price:F2}");
        }
        else
        {
            decimal needFlour = (n * c) - f;
            Console.WriteLine($"Can make only {cakes:F0} cakes, need {needFlour:F2} kg more flour");
        }
    }
}
