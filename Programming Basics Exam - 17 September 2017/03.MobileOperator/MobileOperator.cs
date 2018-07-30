using System;

public class MobileOperator
{
    public static void Main()
    {
        string durationOfContract = Console.ReadLine();
        string type = Console.ReadLine();
        string internet = Console.ReadLine();
        int months = int.Parse(Console.ReadLine());
        double price = 0;

        switch (type)
        {
            case "Small":
                if (durationOfContract == "one")
                {
                    price = 9.98;
                }
                else if (durationOfContract == "two")
                {
                    price = 8.58;
                }
                break;
            case "Middle":
                if (durationOfContract == "one")
                {
                    price = 18.99;
                }
                else if (durationOfContract == "two")
                {
                    price = 17.09;
                }
                break;
            case "Large":
                if (durationOfContract == "one")
                {
                    price = 25.98;
                }
                else if (durationOfContract == "two")
                {
                    price = 23.59;
                }
                break;
            case "ExtraLarge":
                if (durationOfContract == "one")
                {
                    price = 35.99;
                }
                else if (durationOfContract == "two")
                {
                    price = 31.79;
                }
                break;
        }

        if (internet == "yes")
        {
            if (price <= 10)
            {
                price = price + 5.50;
            }
            else if (price <= 30)
            {
                price = price + 4.35;
            }
            else if (price > 30)
            {
                price = price + 3.85;
            }
        }

        if (durationOfContract == "two")
        {
            price = price - (price * 3.75 / 100);
        }

        Console.WriteLine($"{price * months:F2} lv.");
    }
}