using System;

public class ChristmasSock
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int dashes = n * 2;

        Console.WriteLine("|{0}|", new string('-', dashes));
        Console.WriteLine("|{0}|", new string('*', dashes));
        Console.WriteLine("|{0}|", new string('-', dashes));

        int symbol = 2;
        int rombDashes = n - 1;
        for (int i = 1; i <= n - 1; i++)
        {
            Console.WriteLine("|{0}{1}{0}|", new string('-', rombDashes), new string('~', symbol));
            rombDashes--;
            symbol += 2;
        }

        for (int i = 1; i <= n - 2; i++)
        {
            Console.WriteLine("|{0}{1}{0}|", new string('-', rombDashes + 2), new string('~', symbol - 4));
            rombDashes++;
            symbol -= 2;
        }

        int dots = 2 * n + 1;
        int endDashes = 0;
        for (int i = 1; i <= n / 2; i++)
        {
            Console.WriteLine("{0}\\{1}\\", new string('-', endDashes), new string('.', dots));
            endDashes++;
        }


        Console.WriteLine("{0}\\{1}MERRY{1}\\", new string('-', endDashes), new string('.', (dots - 5) / 2));
        endDashes++;
        Console.WriteLine("{0}\\{1}\\", new string('-', endDashes), new string('.', dots));
        endDashes++;
        Console.WriteLine("{0}\\{1}X-MAS{1}\\", new string('-', endDashes), new string('.', (dots - 5) / 2));
        endDashes++;


        for (int i = 1; i <= ((n + 1) / 2) - 1; i++)
        {
            Console.WriteLine("{0}\\{1}\\", new string('-', endDashes), new string('.', dots));
            endDashes++;
        }
        Console.WriteLine("{0}\\{1})", new string('-', endDashes), new string('_', dots));

    }
}