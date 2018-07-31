using System;

public class BikeRace
{
    public static void Main()
    {
        int numberOfJuniors = int.Parse(Console.ReadLine());
        int numberOfSeniors = int.Parse(Console.ReadLine());
        string kindOfTrase = Console.ReadLine();
        double totalPrice = 0;

        switch (kindOfTrase)
        {
            case "trail":
                double juniorTax = 5.5;
                double seniorTax = 7;
                totalPrice = numberOfJuniors * juniorTax + numberOfSeniors * seniorTax;
                totalPrice *= 0.95;
                break;
            case "cross-country":
                juniorTax = 8;
                seniorTax = 9.5;
                totalPrice = numberOfJuniors * juniorTax + numberOfSeniors * seniorTax;
                totalPrice *= 0.95;
                if (numberOfJuniors + numberOfSeniors >= 50)
                {
                    totalPrice *= 0.75;
                }
                break;
            case "downhill":
                juniorTax = 12.25;
                seniorTax = 13.75;
                totalPrice = numberOfJuniors * juniorTax + numberOfSeniors * seniorTax;
                totalPrice *= 0.95;
                break;
            case "road":
                juniorTax = 20;
                seniorTax = 21.5;
                totalPrice = numberOfJuniors * juniorTax + numberOfSeniors * seniorTax;
                totalPrice *= 0.95;
                break;
        }

        Console.WriteLine($"{totalPrice:F2}");
    }
}