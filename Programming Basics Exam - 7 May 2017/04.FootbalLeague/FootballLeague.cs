using System;

public class FootballLeague
{
    public static void Main()
    {
        double stadion = double.Parse(Console.ReadLine());
        double fans = double.Parse(Console.ReadLine());
        double total = fans / stadion * 100;
        double A = 0;
        double B = 0;
        double V = 0;
        double G = 0;


        for (int i = 1; i <= fans; i++)
        {
            string sector = Console.ReadLine();

            if (sector == "A")
            {
                A += 1;
            }
            else if (sector == "B")
            {
                B += 1;
            }
            else if (sector == "V")
            {
                V += 1;
            }
            else if (sector == "G")
            {
                G += 1;
            }
        }

        A = A / fans * 100;
        B = B / fans * 100;
        V = V / fans * 100;
        G = G / fans * 100;

        Console.WriteLine($"{A:F2}%");
        Console.WriteLine($"{B:F2}%");
        Console.WriteLine($"{V:F2}%");
        Console.WriteLine($"{G:F2}%");
        Console.WriteLine($"{total:F2}%");
    }
}