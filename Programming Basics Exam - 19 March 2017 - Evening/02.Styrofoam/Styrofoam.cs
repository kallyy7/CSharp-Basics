using System;

public class Styrofoam
{
    public static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        double houseArea = double.Parse(Console.ReadLine());
        int windows = int.Parse(Console.ReadLine());
        double styrofoam = double.Parse(Console.ReadLine());
        double price = double.Parse(Console.ReadLine());

        double house = houseArea - (windows * 2.4);
        house = house + (house * 0.10);
        double packets = Math.Ceiling(house / styrofoam);
        packets *= price;

        if (packets <= budget)
        {
            Console.WriteLine($"Spent: {packets:F2}");
            double result = budget - packets;
            Console.WriteLine($"Left: {result:F2}");
        }
        else
        {
            double result = packets - budget;
            Console.WriteLine($"Need more: {result:F2}");
        }
    }
}
