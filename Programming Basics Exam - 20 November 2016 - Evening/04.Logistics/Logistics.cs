using System;

public class Logistics
{
    public static void Main()
    {
        int numberOfLoads = int.Parse(Console.ReadLine());
        double price = 0;
        double minibus = 0;
        double truck = 0;
        double train = 0;
        double sum = 0;

        for (int i = 1; i <= numberOfLoads; i++)
        {
            int tonnage = int.Parse(Console.ReadLine());
            sum += tonnage;

            if (tonnage <= 3)
            {
                minibus += tonnage;
            }
            else if (tonnage >= 4 && tonnage <= 11)
            {
                truck += tonnage;
            }
            else
            {
                train += tonnage;
            }
        }
        price = (minibus * 200 + truck * 175 + train * 120) / sum;
        minibus = minibus / sum * 100;
        truck = truck / sum * 100;
        train = train / sum * 100;

        Console.WriteLine($"{price:F2}");
        Console.WriteLine($"{minibus:F2}%");
        Console.WriteLine($"{truck:F2}%");
        Console.WriteLine($"{train:F2}%");
    }
}