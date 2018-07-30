using System;

public class SantaHoliday
{
    public static void Main()
    {
        int days = int.Parse(Console.ReadLine());
        string room = Console.ReadLine();
        string grade = Console.ReadLine();
        double totalNights = 0;

        switch (room)
        {
            case "room for one person":
                totalNights = 18 * (days - 1);
                break;

            case "apartment":
                if (days <= 10)
                {
                    totalNights = 25.00 * (days - 1);
                    totalNights *= 0.7;
                }
                else if (days >= 11 && days <= 15)
                {
                    totalNights = 25.00 * (days - 1);
                    totalNights *= 0.65;
                }
                else if (days > 15)
                {
                    totalNights = 25.00 * (days - 1);
                    totalNights *= 0.5;
                }
                break;

            case "president apartment":
                if (days <= 10)
                {
                    totalNights = 35.00 * (days - 1);
                    totalNights *= 0.9;
                }
                else if (days >= 11 && days <= 15)
                {
                    totalNights = 35.00 * (days - 1);
                    totalNights *= 0.85;
                }
                else if (days > 15)
                {
                    totalNights = 35.00 * (days - 1);
                    totalNights *= 0.8;
                }
                break;
        }

        switch (grade)
        {
            case "positive":
                totalNights *= 1.25;
                break;
            case "negative":
                totalNights *= 0.9;
                break;
        }

        Console.WriteLine($"{totalNights:F2}");
    }
}