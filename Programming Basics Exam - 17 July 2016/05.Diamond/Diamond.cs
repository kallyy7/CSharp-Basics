using System;

public class Diamond
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int dots = n;
        int width = 5 * n;
        int stars = 3 * n;

        Console.WriteLine($@"{new string('.', dots)}{new string('*', stars)}{new string('.', dots)}");
        dots -= 1;

        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine($@"{new string('.', dots)}*{new string('.', stars)}*{new string('.', dots)}");
            stars += 2;
            dots -= 1;
        }
        Console.WriteLine($@"{new string('*', width)}");
        dots = 1;

        for (int i = 0; i < (2 * n) + 1; i++)
        {
            if (i == 2 * n)
            {
                Console.WriteLine($@"{new string('.', dots)}*{new string('*', width - 4)}*{new string('.', dots)}");
            }
            else
            {
                Console.WriteLine($@"{new string('.', dots)}*{new string('.', width - 4)}*{new string('.', dots)}");
            }
            dots += 1;
            width -= 2;
        }
    }
}