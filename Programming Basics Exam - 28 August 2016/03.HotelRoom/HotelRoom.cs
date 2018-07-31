using System;

public class HotelRoom
{
    public static void Main()
    {
        string month = Console.ReadLine();
        int numberOfNights = int.Parse(Console.ReadLine());

        double apartmentPrice = 0;
        double studioPrice = 0;

        if (month == "May" || month == "October")
        {
            studioPrice = 50;
            apartmentPrice = 65;

            if (numberOfNights > 7 && numberOfNights <= 14)
            {
                studioPrice *= 0.95;
            }
            else if (numberOfNights > 14)
            {
                studioPrice *= 0.70;
                apartmentPrice *= 0.90;
            }
        }
        else if (month == "June" || month == "September")
        {
            studioPrice = 75.2;
            apartmentPrice = 68.70;

            if (numberOfNights > 14)
            {
                studioPrice *= 0.80;
                apartmentPrice *= 0.90;
            }
        }
        else if (month == "July" || month == "August")
        {
            studioPrice = 76;
            apartmentPrice = 77;

            if (numberOfNights > 14)
            {
                apartmentPrice *= 0.90;
            }
        }
        studioPrice = studioPrice * numberOfNights;
        apartmentPrice = apartmentPrice * numberOfNights;

        Console.WriteLine($"Apartment: {apartmentPrice:F2} lv.");
        Console.WriteLine($"Studio: {studioPrice:F2} lv.");
    }
}