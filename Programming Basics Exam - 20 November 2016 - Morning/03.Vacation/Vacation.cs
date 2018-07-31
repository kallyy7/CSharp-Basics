using System;

public class Vacation
{
    public static void Main()
    {
        int numberOfAdults = int.Parse(Console.ReadLine());
        int numberOfStudents = int.Parse(Console.ReadLine());
        int numberOfNights = int.Parse(Console.ReadLine());
        string typeOfTransport = Console.ReadLine();

        double totalPrice = 0;
        double adultPrice = 0;
        double studentPrice = 0;
        double transportCost = 0;
        double hotel = 0;

        switch (typeOfTransport)
        {
            case "train":
                adultPrice = 24.99;
                studentPrice = 14.99;

                if ((numberOfAdults + numberOfStudents) >= 50)
                {
                    adultPrice *= 0.5;
                    studentPrice *= 0.5;
                }
                transportCost = (numberOfAdults * adultPrice + numberOfStudents * studentPrice) * 2;
                hotel = numberOfNights * 82.99;
                totalPrice = transportCost + hotel;
                totalPrice = totalPrice + (totalPrice * 0.10);
                break;
            case "bus":
                adultPrice = 32.5;
                studentPrice = 28.5;
                transportCost = (numberOfAdults * adultPrice + numberOfStudents * studentPrice) * 2;
                hotel = numberOfNights * 82.99;
                totalPrice = transportCost + hotel;
                totalPrice = totalPrice + (totalPrice * 0.10);
                break;
            case "boat":
                adultPrice = 42.99;
                studentPrice = 39.99;
                transportCost = (numberOfAdults * adultPrice + numberOfStudents * studentPrice) * 2;
                hotel = numberOfNights * 82.99;
                totalPrice = transportCost + hotel;
                totalPrice = totalPrice + (totalPrice * 0.10);
                break;
            case "airplane":
                adultPrice = 70.0;
                studentPrice = 50.0;
                transportCost = (numberOfAdults * adultPrice + numberOfStudents * studentPrice) * 2;
                hotel = numberOfNights * 82.99;
                totalPrice = transportCost + hotel;
                totalPrice = totalPrice + (totalPrice * 0.10);
                break;
        }

        Console.WriteLine($"{totalPrice:F2}");
    }
}