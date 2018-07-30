using System;

public class AlcoholMarket
{
    public static void Main()
    {
        double whiskey = double.Parse(Console.ReadLine());
        double beerLeters = double.Parse(Console.ReadLine());
        double wineLeters = double.Parse(Console.ReadLine());
        double rakiaLeters = double.Parse(Console.ReadLine());
        double whiskeyLeters = double.Parse(Console.ReadLine());

        double rakiaPrice = whiskey / 2;
        double winePrice = rakiaPrice - (0.4 * rakiaPrice);
        double beerPrice = rakiaPrice - (0.8 * rakiaPrice);
        double rakiaTotalPrice = rakiaLeters * rakiaPrice;
        double wineTotalPrice = wineLeters * winePrice;
        double beerTotalPrice = beerLeters * beerPrice;
        double whiskeyTotalPrice = whiskey * whiskeyLeters;
        double totalPriceAll = rakiaTotalPrice + wineTotalPrice + beerTotalPrice + whiskeyTotalPrice;

        Console.WriteLine($"{totalPriceAll:F2}");
    }
}