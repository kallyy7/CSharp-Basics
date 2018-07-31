using System;

public class Flowers
{
    public static void Main()
    {
        int numberOfChrysanthemums = int.Parse(Console.ReadLine());
        int numberOfRoses = int.Parse(Console.ReadLine());
        int numberOfTulips = int.Parse(Console.ReadLine());
        string season = Console.ReadLine();
        string isHoliday = Console.ReadLine();
        double total = numberOfChrysanthemums + numberOfTulips + numberOfRoses;
        double price = 0;

        if (season == "Spring" || season == "Summer")
        {
            double cenaHrizantemi = 2;
            double cenaRozi = 4.10;
            double cenaLaleta = 2.50;
            price = numberOfChrysanthemums * cenaHrizantemi + numberOfTulips * cenaLaleta + numberOfRoses * cenaRozi;

            if (isHoliday == "Y")
            {
                price = price + (price * 0.15);
            }
            if (season == "Spring" && numberOfTulips > 7)
            {
                price *= 0.95;
            }
        }
        else if (season == "Autumn" || season == "Winter")
        {
            double cenaHrizantemi = 3.75;
            double cenaRozi = 4.50;
            double cenaLaleta = 4.15;
            price = numberOfChrysanthemums * cenaHrizantemi + numberOfTulips * cenaLaleta + numberOfRoses * cenaRozi;

            if (isHoliday == "Y")
            {
                price = price + (price * 0.15);
            }
            if (season == "Winter" && numberOfRoses >= 10)
            {
                price *= 0.90;
            }
        }

        if (total > 20)
        {
            price *= 0.80;
        }
        price += 2;
        Console.WriteLine($"{price:F2}");
    }
}