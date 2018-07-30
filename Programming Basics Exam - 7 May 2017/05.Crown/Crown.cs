using System;

public class Crown
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int width = (2 * n) - 1;
        int space = ((2 * n) - 4) / 2;
        int dots = 1;
        int vdot = 1;

        Console.WriteLine($@"@{new string(' ', space)}@{new string(' ', space)}@");
        space -= 1;
        Console.WriteLine($@"**{new string(' ', space)}*{new string(' ', space)}**");
        space -= 2;

        for (int i = 1; i <= (n / 2) - 2; i++)
        {
            Console.WriteLine($@"*{new string('.', dots)}*{new string(' ', space)}*{new string('.', vdot)}*{new string(' ', space)}*{new string('.', dots)}*");
            space -= 2;
            dots += 1;
            vdot += 2;
        }

        Console.WriteLine($@"*{new string('.', (n / 2) - 1)}*{new string('.', n - 3)}*{new string('.', (n / 2) - 1)}*");
        Console.WriteLine($@"*{new string('.', (n / 2))}{new string('*', ((width - 3) - n) / 2)}.{new string('*', ((width - 3) - n) / 2)}{new string('.', (n / 2))}*");

        for (int row = 0; row < 2; row++)
        {
            for (int i = 0; i < width; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}