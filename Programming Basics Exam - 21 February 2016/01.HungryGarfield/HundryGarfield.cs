using System;

public class HundryGarfield
{
    public static void Main()
    {
        decimal money = decimal.Parse(Console.ReadLine());
        decimal rate = decimal.Parse(Console.ReadLine());
        decimal pizzaPrice = decimal.Parse(Console.ReadLine());
        decimal lasagnaPrice = decimal.Parse(Console.ReadLine());
        decimal sandwichPrice = decimal.Parse(Console.ReadLine());
        decimal pizzaQuantity = decimal.Parse(Console.ReadLine());
        decimal lasagnaQuantity = decimal.Parse(Console.ReadLine());
        decimal sandwichQuantity = decimal.Parse(Console.ReadLine());

        decimal moneyNeed = Math.Round((pizzaPrice / rate * pizzaQuantity) + (lasagnaPrice / rate * lasagnaQuantity) + (sandwichPrice / rate * sandwichQuantity), 2);

        if (moneyNeed <= money)
        {
            decimal left = money - moneyNeed;
            Console.WriteLine($"Garfield is well fed, John is awesome. Money left: ${left:F2}.");
        }
        else
        {
            decimal needed = moneyNeed - money;
            Console.WriteLine($"Garfield is hungry. John is a badass. Money needed: ${needed:F2}.");
        }
    }
}