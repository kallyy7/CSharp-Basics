using System;

public class LadyBug
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int width = 2 * n + 1;
        int space = (width - 3) / 2;

        Console.WriteLine($@"{new string(' ', ((2 * n + 1) - 5) / 2)}@{new string(' ', 3)}@{new string(' ', ((2 * n + 1) - 5) / 2)}");
        Console.WriteLine($@"{new string(' ', ((2 * n + 1) - 3) / 2)}\_/{new string(' ', ((2 * n + 1) - 3) / 2)}");
        Console.WriteLine($@"{new string(' ', ((2 * n + 1) - 3) / 2)}/ \{new string(' ', ((2 * n + 1) - 3) / 2)}");
        Console.WriteLine($@"{new string(' ', ((2 * n + 1) - 3) / 2)}|_|{new string(' ', ((2 * n + 1) - 3) / 2)}");

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($@"{new string(' ', space)}/{new string(' ', i)}|{new string(' ', i)}\{new string(' ', space)}");
            space -= 1;
        }

        for (int i = 0; i < (n / 2); i++)
        {
            space = (width - 5) / 2;

            if (n % 2 == 0)
            {
                Console.WriteLine($@"|{new string(' ', spacee / 2)}@{new string(' ', spacee / 2)}|{new string(' ', spacee / 2)}@{new string(' ', spacee / 2)}|");
            }
            else
            {
                Console.WriteLine($@"|{new string(' ', spacee / 2)}@{new string(' ', spacee / 2 + 1)}|{new string(' ', spacee / 2 + 1)}@{new string(' ', spacee / 2)}|");
            }
        }
        space = (width - 3) / 2;

        for (int i = 0; i < n / 2; i++)
        {
            if (n == 2)
            {
                break;
            }

            Console.WriteLine($@"{new string(' ', i)}\{new string(' ', space)}|{new string(' ', space)}/{new string(' ', i)}");
            space -= 1;
        }

        if (n % 2 == 0)
        {
            Console.WriteLine($@"{new string(' ', n / 2)}{new string('^', n / 2)}|{new string('^', n / 2)}");
        }
        else
        {
            Console.WriteLine($@"{new string(' ', n / 2 + 1)}{new string('^', n / 2)}|{new string('^', n / 2)}");
        }
    }
}
