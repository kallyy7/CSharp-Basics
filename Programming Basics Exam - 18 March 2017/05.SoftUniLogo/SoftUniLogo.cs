using System;

public class SoftUniLogo
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int hashtag = 1;
        int dots = ((12 * n) - 6) / 2;

        for (int i = 0; i < n * 2; i++)
        {
            Console.WriteLine($@"{new string('.', dots)}{new string('#', hashtag)}{new string('.', dots)}");
            dots -= 3;
            hashtag += 6;
        }
        hashtag -= 12;
        dots += 6;

        for (int i = 0; i < n - 2; i++)
        {
            Console.WriteLine($@"|{new string('.', dots - 1)}{new string('#', hashtag)}{new string('.', dots)}");
            hashtag -= 6;
            dots += 3;
        }

        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine($@"|{new string('.', dots - 1)}{new string('#', hashtag)}{new string('.', dots)}");
        }

        Console.WriteLine($@"@{new string('.', dots - 1)}{new string('#', hashtag)}{new string('.', dots)}");
    }
}