using System;

public class SandBox
{
    public static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double priceSand = double.Parse(Console.ReadLine());
        double priceBoard = double.Parse(Console.ReadLine());

        double totalArea = a * b;
        double sandstoneArea = ((a - 0.4) * (b - 0.4));
        double curbStone = totalArea - sandstoneArea;
        double needSand = Math.Ceiling(sandstoneArea * 20);
        double needBoard = Math.Ceiling(curbStone / (2.2 * 0.2));
        double sandPrice = needSand * priceSand;
        double boardPrice = needBoard * priceBoard;
        double totalPrice = sandPrice + boardPrice;

        Console.WriteLine($"{totalPrice:F2}");
    }
}