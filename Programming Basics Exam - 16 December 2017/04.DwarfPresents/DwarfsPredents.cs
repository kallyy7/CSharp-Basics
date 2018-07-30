using System;

public class DwarfsPredents
{
    public static void Main()
    {
        int dwarfs = int.Parse(Console.ReadLine());
        int money = int.Parse(Console.ReadLine());
        double price = 0;
        double total = 0;

        for (int i = 1; i <= dwarfs; i++)
        {
            string present = Console.ReadLine();

            if (present == "sand clock")
            {
                price = 2.20;
            }
            else if (present == "magnet")
            {
                price = 1.50;
            }
            else if (present == "cup")
            {
                price = 5.0;
            }
            else if (present == "t-shirt")
            {
                price = 10.0;
            }

            total += price;
        }

        if (total <= money)
        {
            double result = money - total;
            Console.WriteLine($"Santa Claus has {result:F2} more leva left!");
        }
        else
        {
            double result = total - money;
            Console.WriteLine($"Santa Claus will need {result:F2} more leva.");
        }
    }
}