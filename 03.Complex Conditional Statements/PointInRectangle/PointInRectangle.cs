using System;

class PointInRectangle
{
    public static void Main()
    {

        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        bool inside = x >= x1 && x <= x2 && y >= y1 && y <= y2;

        if (inside)
        {
            Console.WriteLine("Inside");
        }
        else
        {
            Console.WriteLine("Outside");
        }
    }
}

