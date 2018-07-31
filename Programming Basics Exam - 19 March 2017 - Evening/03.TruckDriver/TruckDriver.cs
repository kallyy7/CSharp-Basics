using System;

public class TruckDriver
{
    public static void Main()
    {
        string season = Console.ReadLine();
        double kmForMonth = double.Parse(Console.ReadLine());
        double salary = 0;

        if (season == "Spring" || season == "Autumn")
        {
            if (kmForMonth <= 5000)
            {
                salary = (kmForMonth * 0.75) * 4;
            }
            else if (kmForMonth > 5000 && kmForMonth <= 10000)
            {
                salary = (kmForMonth * 0.95) * 4;
            }
            else if (kmForMonth > 10000 && kmForMonth <= 20000)
            {
                salary = (kmForMonth * 1.45) * 4;
            }
        }
        else if (season == "Summer")
        {
            if (kmForMonth <= 5000)
            {
                salary = (kmForMonth * 0.90) * 4;
            }
            else if (kmForMonth > 5000 && kmForMonth <= 10000)
            {
                salary = (kmForMonth * 1.10) * 4;
            }
            else if (kmForMonth > 10000 && kmForMonth <= 20000)
            {
                salary = (kmForMonth * 1.45) * 4;
            }
        }
        else if (season == "Winter")
        {
            if (kmForMonth <= 5000)
            {
                salary = (kmForMonth * 1.05) * 4;
            }
            else if (kmForMonth > 5000 && kmForMonth <= 10000)
            {
                salary = (kmForMonth * 1.25) * 4;
            }
            else if (kmForMonth > 10000 && kmForMonth <= 20000)
            {
                salary = (kmForMonth * 1.45) * 4;
            }
        }

        salary *= 0.90;
        Console.WriteLine($"{salary:F2}");
    }
}