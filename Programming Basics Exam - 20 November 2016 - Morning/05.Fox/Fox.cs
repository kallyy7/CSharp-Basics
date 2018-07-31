using System;

public class Fox
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int m = n;
        int width = (2 * n) + 3;
        int hyphenMinus = width - 4;
        int stars = n / 2;

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($@"{new string('*', i)}\{new string('-', hyphenMinus)}/{new string('*', i)}");
            hyphenMinus -= 2;
        }

        if (n == 7)
        {
            for (int i = 0; i <= n / 3; i++)
            {
                Console.WriteLine($@"|{new string('*', stars)}\{new string('*', n)}/{new string('*', stars)}|");
                stars += 1;
                n -= 2;
            }
        }
        else
        {
            for (int i = 0; i <= (n / 3) + 1; i++)
            {
                Console.WriteLine($@"|{new string('*', stars)}\{new string('*', n)}/{new string('*', stars)}|");
                stars += 1;
                n -= 2;
            }
        }
        hyphenMinus = width - 4;

        for (int i = 1; i <= m; i++)
        {
            Console.WriteLine($@"{new string('-', i)}\{new string('*', hyphenMinus)}/{new string('-', i)}");
            hyphenMinus -= 2;
        }
    }
}