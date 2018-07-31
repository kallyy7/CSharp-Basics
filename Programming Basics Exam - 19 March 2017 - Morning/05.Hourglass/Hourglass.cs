using System;

public class Hourglass
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int space = (2 * n) - 3;
        int dots = 2;

        Console.WriteLine($@"{new string('*', (2 * n) + 1)}");
        Console.WriteLine($@".*{new string(' ', space)}*.");
        space -= 2;

        for (int i = 0; i < n - 2; i++)
        {
            Console.WriteLine($@"{new string('.', dots)}*{new string('@', space)}*{new string('.', dots)}");
            space -= 2;
            dots += 1;
        }

        Console.WriteLine($@"{new string('.', n)}*{new string('.', n)}");
        space = 0;
        for (int i = 1; i <= n - 2; i++)
        {
            Console.WriteLine($@"{new string('.', n - i)}*{new string(' ', space)}@{new string(' ', space)}*{new string('.', n - i)}");
            space += 1;
        }

        space = (2 * n) - 3;
        Console.WriteLine($@".*{new string('@', space)}*.");
        Console.WriteLine($@"{new string('*', (2 * n) + 1)}");
    }
}