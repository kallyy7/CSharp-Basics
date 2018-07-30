using System;

public class WireNet
{
    public static void Main()
    {
        int lenght = int.Parse(Console.ReadLine());
        int width = int.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double PriceOfNet = double.Parse(Console.ReadLine());
        double weightPerMeter = double.Parse(Console.ReadLine());

        double lenghtOfWireNet = (2 * lenght) + (2 * width);
        double priceOfWireNet = lenghtOfWireNet * PriceOfNet;
        double areaOfWireNet = lenghtOfWireNet * height;
        double weightOfWireNet = areaOfWireNet * weightPerMeter;

        Console.WriteLine(lenghtOfWireNet);
        Console.WriteLine($"{priceOfWireNet:F2}");
        Console.WriteLine($"{weightOfWireNet:F3}");
    }
}
