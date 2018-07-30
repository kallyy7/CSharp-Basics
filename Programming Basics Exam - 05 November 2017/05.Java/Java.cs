using System;

public class Java
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int height = 3 * n + 1;
        int width = 3 * n + 6;
        int at = (n * 2) + 4;
        int space = 0;

        // first part
        for (int row = 1; row <= n; row++)
        {
            Console.Write(new string(' ', n));
            for (int col = 1; col <= 3; col++)
            {
                Console.Write("~ ");
            }
            Console.WriteLine();
        }
        Console.Write(new string('=', width - 1));
        Console.Write(new string(' ', 1));
        Console.WriteLine();

        // second part
        for (int row = 1; row <= n - 2; row++)
        {
            for (int i = 0; i < 1; i++)
            {
                if (row == (n / 2))
                {
                    Console.Write(new string('|', 1));
                    Console.Write(new string('~', n));
                    Console.Write("JAVA");
                    Console.Write(new string('~', n));
                    Console.Write(new string('|', 1));
                    Console.Write(new string(' ', n - 1));
                    Console.Write(new string('|', 1));

                }
                else
                {
                    Console.Write(new string('|', 1));
                    Console.Write(new string('~', (n * 2) + 4));
                    Console.Write(new string('|', 1));
                    Console.Write(new string(' ', n - 1));
                    Console.Write(new string('|', 1));
                }
            }
            Console.WriteLine();
        }
        Console.Write(new string('=', width - 1));
        Console.Write(new string(' ', 1));
        Console.WriteLine();

        // third part
        for (int row = 1; row <= n; row++)
        {
            for (int col = 0; col < 1; col++)
            {
                Console.Write(new string(' ', space));
                Console.Write(@"\");
                Console.Write(new string('@', at));
                Console.Write(@"/");
                space += 1;
                at -= 2;
            }
            Console.WriteLine();
        }

        Console.Write(new string('=', (n * 2) + 6));
        Console.WriteLine();
    }
}
