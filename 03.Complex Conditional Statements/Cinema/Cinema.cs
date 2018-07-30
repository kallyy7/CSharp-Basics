using System;

class Cinema
{
    public static void Main()
    {
        string projectionType = Console.ReadLine();
        int r = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        double result = 0.0;

        if (projectionType == "Premiere")
        {
            result = r * c * 12.00;
        }
        else if (projectionType == "Normal")
        {
            result = r * c * 7.50;
        }
        else if (projectionType == "Discount")
        {
            result = r * c * 5.00;
        }

        Console.WriteLine("{0:f2} leva", result);
    }
}
