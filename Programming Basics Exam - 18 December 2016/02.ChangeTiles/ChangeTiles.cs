using System;

public class ChangeTiles
{
    public static void Main()
    {
        double money = double.Parse(Console.ReadLine());
        double floorWidth = double.Parse(Console.ReadLine());
        double floorLength = double.Parse(Console.ReadLine());
        double triangleSide = double.Parse(Console.ReadLine());
        double triangleHeigh = double.Parse(Console.ReadLine());
        double tilePrice = double.Parse(Console.ReadLine());
        double priceWorkman = double.Parse(Console.ReadLine());

        double floorArea = floorWidth * floorLength;
        double pileArea = triangleSide * triangleHeigh / 2;
        double needPiles = Math.Ceiling(floorArea / pileArea) + 5;
        double totalPrice = needPiles * tilePrice + priceWorkman;

        if (totalPrice <= money)
        {
            double result = money - totalPrice;
            Console.WriteLine($"{result:F2} lv left.");
        }
        else
        {
            double result = totalPrice - money;
            Console.WriteLine($"You'll need {result:F2} lv more.");
        }
    }
}