using System;

public class FruityCocktails
{
    public static void Main()
    {
        string fruit = Console.ReadLine();
        string size = Console.ReadLine();
        int numberOfDrinks = int.Parse(Console.ReadLine());

        double price = 0;
        double smallPrice = 0;
        double bigPrice = 0;

        switch (fruit)
        {
            case "Watermelon":
                if (size == "small")
                {
                    smallPrice = 2 * 56;
                    price = smallPrice * numberOfDrinks;
                }
                else if (size == "big")
                {
                    bigPrice = 5 * 28.70;
                    price = bigPrice * numberOfDrinks;
                }
                break;
            case "Mango":
                if (size == "small")
                {
                    smallPrice = 2 * 36.66;
                    price = smallPrice * numberOfDrinks;
                }
                else if (size == "big")
                {
                    bigPrice = 5 * 19.60;
                    price = bigPrice * numberOfDrinks;
                }
                break;
            case "Pineapple":
                if (size == "small")
                {
                    smallPrice = 2 * 42.10;
                    price = smallPrice * numberOfDrinks;
                }
                else if (size == "big")
                {
                    bigPrice = 5 * 24.80;
                    price = bigPrice * numberOfDrinks;
                }
                break;
            case "Raspberry":
                if (size == "small")
                {
                    smallPrice = 2 * 20;
                    price = smallPrice * numberOfDrinks;
                }
                else if (size == "big")
                {
                    bigPrice = 5 * 15.20;
                    price = bigPrice * numberOfDrinks;
                }
                break;
        }

        if (price > 1000)
        {
            price *= 0.50;
        }
        else if (price >= 400 && price <= 1000)
        {
            price *= 0.85;
        }

        Console.WriteLine($"{price:F2} lv.");
    }
}