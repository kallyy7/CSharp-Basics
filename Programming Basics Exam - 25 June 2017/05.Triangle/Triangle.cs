using System;

public class Triangle
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int space = 1;
        int width = (4 * n) + 1;
        int dots = 1;
        Console.WriteLine($@"{ new string('#', (4 * n) + 1) }");

        for (int i = 1; i <= n / 2; i++)
        {
            Console.WriteLine($@"{new string('.', dots)}{new string('#', (width - 3) / 2)}{new string(' ', space)}
                                 {new string('#', (width - 3) / 2)}{new string('.', dots)}");
            dots += 1;
            space += 2;
            width -= 4;
        }
        Console.WriteLine($@"{new string('.', dots)}{new string('#', (width - 3) / 2)}{new string(' ', (n / 2) - 1)}
                          (@){new string(' ', (n / 2) - 1)}{new string('#', (width - 3) / 2)}{new string('.', n / 2 + 1)}");
        width -= 4;
        space += 2;
        dots += 1;

        if (n % 2 == 0)
        {
            for (int i = 1; i <= (n / 2) - 1; i++)
            {
                Console.WriteLine($@"{new string('.', dots)}{new string('#', (width - 3) / 2)}{new string(' ', space)}
                                     {new string('#', (width - 3) / 2)}{new string('.', dots)}");
                dots += 1;
                space += 2;
                width -= 4;
            }
        }
        else
        {
            for (int i = 1; i <= n / 2; i++)
            {
                Console.WriteLine($@"{new string('.', dots)}{new string('#', (width - 3) / 2)}{new string(' ', space)}{new string('#', (width - 3) / 2)}{new string('.', dots)}");
                dots += 1;
                space += 2;
                width -= 4;
            }
        }
        dots = n + 1;
        width = (n * 2) - 1;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($@"{new string('.', dots)}{new string('#', width)}{new string('.', dots)}");
            dots += 1;
            width -= 2;
        }
    }
}