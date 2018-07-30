using System;

class Travel
{
    public static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        string season = Console.ReadLine();
        double sum = 0;

        if (budget <= 100)
        {
            Console.WriteLine("Somewhere in Bulgaria");

            if (season == "summer")
            {
                Console.Write("Camp - ");
                sum = budget * 0.3;
            }
            else if (season == "winter")
            {
                Console.Write("Hotel - ");
                sum = budget * 0.7;
            }
        }
        else if (budget > 100 && budget <= 1000)
        {
            Console.WriteLine("Somewhere in Balkans");

            if (season == "summer")
            {
                Console.Write("Camp - ");
                sum = budget * 0.4;
            }
            else if (season == "winter")
            {
                Console.Write("Hotel - ");
                sum = budget * 0.8;
            }
        }
        else if (budget > 1000)
        {
            Console.WriteLine("Somewhere in Europe");

            Console.Write("Hotel - ");
            sum = budget * 0.9;

        }
        Console.WriteLine($"{sum:F2}");
    }
}
