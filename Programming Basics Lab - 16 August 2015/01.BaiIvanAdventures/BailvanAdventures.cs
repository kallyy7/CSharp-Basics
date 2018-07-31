using System;

public class BailvanAdventures
{
    public static void Main()
    {
        string dayOfWeek = Console.ReadLine();
        decimal money = decimal.Parse(Console.ReadLine());
        decimal liters = decimal.Parse(Console.ReadLine());

        decimal price = 0;
        string status = null;

        switch (dayOfWeek)
        {
            case "0":
                price = 25.0m;
                break;
            case "1":
                price = 21.0m;
                break;
            case "2":
                price = 14.0m;
                break;
            case "3":
                price = 17.0m;
                break;
            case "4":
                price = 45.0m;
                break;
            case "5":
                price = 59.0m;
                break;
            case "6":
                price = 42.0m;
                break;
        }
        decimal afford = money / price;

        if (afford > 1.5m)
        {
            status = "very drunk";
        }
        else if (afford >= 1.0m)
        {
            status = "drunk";
        }
        else
        {
            status = "sober";
        }

        if (liters < afford)
        {
            Console.WriteLine($"Bai Ivan is {status} and very happy and he shared {(afford - liters):F2} l. of alcohol with his friends");
        }
        else if (liters == afford)
        {
            Console.WriteLine($"Bai Ivan is {status} and happy. He is as drunk as he wanted");
        }
        else
        {
            Console.WriteLine($"Bai Ivan is {status} and quite sad. He wanted to drink another {(liters - afford):F2} l. of alcohol");
        }
    }
}