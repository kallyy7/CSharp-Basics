using System;

public class SoftUniCamp
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        double totalPeople = 0;
        double car = 0;
        double minibus = 0;
        double smallBus = 0;
        double bus = 0;
        double train = 0;

        for (int i = 1; i <= n; i++)
        {
            int num = int.Parse(Console.ReadLine());

            if (num <= 5)
            {
                car += num;
                totalPeople += num;
            }
            else if (num > 5 && num <= 12)
            {
                minibus += num;
                totalPeople += num;
            }
            else if (num > 12 && num <= 25)
            {
                smallBus += num;
                totalPeople += num;
            }
            else if (num > 25 && num <= 40)
            {
                bus += num;
                totalPeople += num;
            }
            else
            {
                train += num;
                totalPeople += num;
            }
        }
        double carPercentage = car * 100.00 / totalPeople;
        double microbusPercentage = minibus * 100.00 / totalPeople;
        double smallBusPercentage = smallBus * 100.00 / totalPeople;
        double busPercentage = bus * 100.00 / totalPeople;
        double trainPercentage = train * 100.00 / totalPeople;

        Console.WriteLine("{0:F02}%", carPercentage);
        Console.WriteLine("{0:F02}%", microbusPercentage);
        Console.WriteLine("{0:F02}%", smallBusPercentage);
        Console.WriteLine("{0:F02}%", busPercentage);
        Console.WriteLine("{0:F02}%", trainPercentage);
    }

}