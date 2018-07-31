using System;

public class HousePrice
{
    public static void Main()
    {
        double smallRoom = double.Parse(Console.ReadLine());
        double kitchen = double.Parse(Console.ReadLine());
        double priceMeter = double.Parse(Console.ReadLine());

        double secondRoom = smallRoom + (smallRoom * 0.10);
        double thirdRoom = secondRoom + (secondRoom * 0.10);
        double bathroom = smallRoom / 2;
        double area = smallRoom + kitchen + secondRoom + thirdRoom + bathroom;
        double hall = area * 0.05;
        double wholeArea = area + hall;
        double price = wholeArea * priceMeter;

        Console.WriteLine($"{price:F2}");
    }
}