using System;

public class ChristmasHat
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int dots = (2 * n) - 1;

        Console.WriteLine($@"{new string('.', dots)}/|\{new string('.', dots)}");
        Console.WriteLine($@"{new string('.', dots)}\|/{new string('.', dots)}");

        for (int i = 0; i < n * 2; i++)
        {
            Console.WriteLine($@"{new string('.', dots)}*{new string('-', i)}*{new string('-', i)}*{new string('.', dots)}");
            dots -= 1;
        }
        Console.WriteLine($@"{new string('*', (4 * n) + 1)}");

        for (int row = 0; row < 1; row++)
        {
            for (int i = 0; i < ((4 * n) + 1) / 2; i++)
            {
                Console.Write("*.");
            }
        }
        Console.Write("*");
        Console.WriteLine();
        Console.WriteLine($@"{new string('*', (4 * n) + 1)}");
    }
}