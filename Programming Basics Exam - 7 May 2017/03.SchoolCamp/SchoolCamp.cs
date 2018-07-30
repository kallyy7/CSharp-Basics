using System;

public class SchoolCamp
{
    public static void Main()
    {
        string season = Console.ReadLine();
        string kindOfGroup = Console.ReadLine();
        int numberOfStudents = int.Parse(Console.ReadLine());
        int numberOfNights = int.Parse(Console.ReadLine());
        string sport = null;
        double price = 0;

        if (season == "Winter")
        {
            if (kindOfGroup == "girls")
            {
                Console.Write("Gymnastics");
                price = numberOfStudents * 9.60 * numberOfNights;
            }
            else if (kindOfGroup == "boys")
            {
                Console.Write("Judo");
                price = numberOfStudents * 9.60 * numberOfNights;
            }
            else if (kindOfGroup == "mixed")
            {
                Console.Write("Ski");
                price = numberOfStudents * 10 * numberOfNights;
            }
        }
        else if (season == "Spring")
        {
            if (kindOfGroup == "girls")
            {
                Console.Write("Athletics");
                price = numberOfStudents * 7.20 * numberOfNights;
            }
            else if (kindOfGroup == "boys")
            {
                Console.Write("Tennis");
                price = numberOfStudents * 7.20 * numberOfNights;
            }
            else if (kindOfGroup == "mixed")
            {
                Console.Write("Cycling");
                price = numberOfStudents * 9.50 * numberOfNights;
            }
        }
        else if (season == "Summer")
        {
            if (kindOfGroup == "girls")
            {
                Console.Write("Volleyball");
                price = numberOfStudents * 15 * numberOfNights;
            }
            else if (kindOfGroup == "boys")
            {
                Console.Write("Football");
                price = numberOfStudents * 15 * numberOfNights;
            }
            else if (kindOfGroup == "mixed")
            {
                Console.Write("Swimming");
                price = numberOfStudents * 20 * numberOfNights;
            }
        }
        if (numberOfStudents >= 50)
        {
            price *= 0.50;
        }
        else if (numberOfStudents >= 20 && numberOfStudents < 50)
        {
            price *= 0.85;
        }
        else if (numberOfStudents >= 10 && numberOfStudents < 20)
        {
            price *= 0.95;
        }

        Console.WriteLine($" {price:F2} lv.");
    }
}