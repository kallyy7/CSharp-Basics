using System;

public class GrandpaStavri
{
    public static void Main()
    {
        int days = int.Parse(Console.ReadLine());
        double total = 0;
        double totalLiters = 0;

        for (int i = 1; i <= days; i++)
        {
            double quantity = double.Parse(Console.ReadLine());
            double degrees = double.Parse(Console.ReadLine());

            totalLiters += quantity;
            double totalQuantity = total + degrees * quantity;
            total = totalQuantity;

        }
        double degrees = total / totalLiters;

        Console.WriteLine($"Liter: {totalLiters:F2}");
        Console.WriteLine($"Degrees: {degrees:F2}");

        if (degrees < 38)
        {
            Console.WriteLine("Not good, you should baking!");
        }
        else if (degrees >= 38 && degrees < 42)
        {
            Console.WriteLine("Super!");
        }
        else if (degrees > 42)
        {
            Console.WriteLine("Dilution with distilled water!");
        }
    }
}
