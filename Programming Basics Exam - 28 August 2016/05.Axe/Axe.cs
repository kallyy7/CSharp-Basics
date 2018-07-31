using System;

public class Axe
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int hyphenMinus = (2 * n) - 2;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($@"{new string('-', 3 * n)}*{new string('-', i)}*{new string('-', hyphenMinus)}");
            hyphenMinus -= 1;
        }
        hyphenMinus += 1;

        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine($@"{new string('*', 3 * n)}*{new string('-', n - 1)}*{new string('-', hyphenMinus)}");
        }

        for (int i = 0; i < n / 2; i++)
        {
            if (i == (n / 2) - 1)
            {
                Console.WriteLine($@"{new string('-', (3 * n) - i)}*{new string('*', (n - 1) + i * 2)}*{new string('-', hyphenMinus - i)}");
            }
            else
            {
                Console.WriteLine($@"{new string('-', (3 * n) - i)}*{new string('-', (n - 1) + i * 2)}*{new string('-', hyphenMinus - i)}");
            }
        }
    }
}