using System;

public class ToyShop
{
    public static void Main()
    {
        double price = double.Parse(Console.ReadLine());
        int numberOfPuzzles = int.Parse(Console.ReadLine());
        int numberOfDolls = int.Parse(Console.ReadLine());
        int numberOfBears = int.Parse(Console.ReadLine());
        int numberOfMinions = int.Parse(Console.ReadLine());
        int numberOfTrucks = int.Parse(Console.ReadLine());

        double price = numberOfPuzzles * 2.60 + numberOfDolls * 3 + numberOfBears * 4.10 + numberOfMinions * 8.20 + numberOfTrucks * 2;
        double broiIgrachki = numberOfPuzzles + numberOfDolls + numberOfBears + numberOfMinions + numberOfTrucks;

        if (broiIgrachki >= 50)
        {
            price *= 0.75;
        }

        double totalWithRent = price * 0.9;

        if (totalWithRent >= price)
        {
            double result = totalWithRent - price;
            Console.WriteLine($"Yes! {result:F2} lv left.");
        }
        else
        {
            double result = price - totalWithRent;
            Console.WriteLine($"Not enough money! {result:F2} lv needed.");
        }
    }
}