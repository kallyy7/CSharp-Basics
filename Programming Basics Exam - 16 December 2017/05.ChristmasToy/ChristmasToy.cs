using System;

public class ChristmasToy
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int height = (2 * n + 3) / 2;
        int width = 5 * n;
        int hyphenMinus = width - n;
        int stars = 1;
        int ampersand = n + 2;
        int tilde = (3 * n) - 2;

        Console.Write(new string('-', hyphenMinus / 2));
        Console.Write(new string('*', n));
        Console.Write(new string('-', hyphenMinus / 2));
        Console.WriteLine();

        hyphenMinus -= 4;
        for (int row = 1; row <= height - 1; row++)
        {
            for (int col = 0; col < 1; col++)
            {
                if (row >= 1 && row <= n / 2)
                {
                    Console.Write(new string('-', hyphenMinus / 2));
                    Console.Write(new string('*', stars));
                    Console.Write(new string('&', ampersand));
                    Console.Write(new string('*', stars));
                    Console.Write(new string('-', hyphenMinus / 2));

                    ampersand += 2;
                    stars += 1;
                    hyphenMinus -= 4;
                }
                else
                {
                    Console.Write(new string('-', (hyphenMinus / 2) + 1));
                    Console.Write(new string('*', 2));
                    Console.Write(new string('~', tilde));
                    Console.Write(new string('*', 2));
                    Console.Write(new string('-', (hyphenMinus / 2) + 1));

                    hyphenMinus -= 2;
                    tilde += 2;
                }
            }

            Console.WriteLine();
        }

        Console.Write(new string('-', n / 2));
        Console.Write(new string('*', 1));
        Console.Write(new string('|', (width - 2) - n));
        Console.Write(new string('*', 1));
        Console.Write(new string('-', n / 2));
        Console.WriteLine();

        hyphenMinus = n / 2;
        tilde = (4 * n) - 4;
        ampersand = n * 2;
        stars = n / 2;

        for (int row = 1; row <= height - 1; row++)
        {
            for (int col = 0; col < 1; col++)
            {
                if (row >= 1 && row <= n / 2)
                {
                    Console.Write(new string('-', hyphenMinus));
                    Console.Write(new string('*', 2));
                    Console.Write(new string('~', tilde));
                    Console.Write(new string('*', 2));
                    Console.Write(new string('-', hyphenMinus));

                    hyphenMinus += 1;
                    tilde -= 2;
                }
                else
                {
                    Console.Write(new string('-', hyphenMinus));
                    Console.Write(new string('*', stars));
                    Console.Write(new string('&', ampersand));
                    Console.Write(new string('*', stars));
                    Console.Write(new string('-', hyphenMinus));

                    stars -= 1;
                    ampersand -= 2;
                    hyphenMinus += 2;
                }
            }

            Console.WriteLine();
        }

        Console.Write(new string('-', hyphenMinus));
        Console.Write(new string('*', n));
        Console.Write(new string('-', hyphenMinus));
        Console.WriteLine();
    }
}