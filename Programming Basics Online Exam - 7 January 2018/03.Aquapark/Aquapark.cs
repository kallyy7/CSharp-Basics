using System;

public class Aquapark
{
    public static void Main()
    {
        string month = Console.ReadLine().ToLower();
        int hours = int.Parse(Console.ReadLine());
        int people = int.Parse(Console.ReadLine());
        string dayOrNight = Console.ReadLine();

        double pricePerPerson = 0;
        double totalPrice = 0;

        if (month == "March" || month == "April" || month == "May")
        {
            if (dayOrNight == "day")
            {
                pricePerPerson = 10.50;
            }
            else if (dayOrNight == "night")
            {
                pricePerPerson = 8.40;
            }
        }
        else if (month == "June" || month == "July" || month == "August")
        {
            if (dayOrNight == "day")
            {
                pricePerPerson = 12.60;
            }
            else if (dayOrNight == "night")
            {
                pricePerPerson = 10.20;
            }
        }

        if (people >= 4)
        {
            pricePerPerson *= 0.9;
        }

        if (hours >= 5)
        {
            pricePerPerson *= 0.5;
        }
        totalPrice = (pricePerPerson * hours) * people;

        Console.WriteLine($"Price per person for one hour: {pricePerPerson:F2}");
        Console.WriteLine($"Total cost of the visit: {totalPrice:F2}");
    }
}