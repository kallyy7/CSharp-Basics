using System;

public class Sheriff
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int x = n;
        int dots = (n - 1) / 2;

        Console.Write(new string('.', ((n * 3) - 1) / 2));
        Console.Write(new string('x', 1));
        Console.Write(new string('.', ((n * 3) - 1) / 2));
        Console.WriteLine();
        Console.Write(new string('.', ((n * 3) - 3) / 2));
        Console.Write(@"/x\");
        Console.Write(new string('.', ((n * 3) - 3) / 2));
        Console.WriteLine();
        Console.Write(new string('.', ((n * 3) - 3) / 2));
        Console.Write("x|x");
        Console.Write(new string('.', ((n * 3) - 3) / 2));
        Console.WriteLine();

        for (int row = 1; row <= (n / 2) + 1; row++)
        {
            for (int col = 0; col < 1; col++)
            {
                Console.Write(new string('.', dots));
                Console.Write(new string('x', x));
                Console.Write(new string('|', 1));
                Console.Write(new string('x', x));
                Console.Write(new string('.', dots));
                dots -= 1;
                x += 1;
            }

            Console.WriteLine();
        }
        dots += 1;
        x -= 1;

        for (int row = 1; row <= n / 2; row++)
        {
            for (int col = 0; col < 1; col++)
            {
                dots += 1;
                x -= 1;

                Console.Write(new string('.', dots));
                Console.Write(new string('x', x));
                Console.Write(new string('|', 1));
                Console.Write(new string('x', x));
                Console.Write(new string('.', dots));
            }

            Console.WriteLine();
        }

        Console.Write(new string('.', ((n * 3) - 3) / 2));
        Console.Write(@"/x\");
        Console.Write(new string('.', ((n * 3) - 3) / 2));
        Console.WriteLine();
        Console.Write(new string('.', ((n * 3) - 3) / 2));
        Console.Write(@"\x/");
        Console.Write(new string('.', ((n * 3) - 3) / 2));
        Console.WriteLine();
        for (int row = 1; row <= (n / 2) + 1; row++)
        {
            for (int col = 0; col < 1; col++)
            {
                Console.Write(new string('.', dots));
                Console.Write(new string('x', x));
                Console.Write(new string('|', 1));
                Console.Write(new string('x', x));
                Console.Write(new string('.', dots));

                dots -= 1;
                x += 1;
            }

            Console.WriteLine();
        }
        dots += 1;
        x -= 1;

        for (int row = 1; row <= n / 2; row++)
        {
            for (int col = 0; col < 1; col++)
            {
                dots += 1;
                x -= 1;

                Console.Write(new string('.', dots));
                Console.Write(new string('x', x));
                Console.Write(new string('|', 1));
                Console.Write(new string('x', x));
                Console.Write(new string('.', dots));
            }

            Console.WriteLine();
        }

        Console.Write(new string('.', ((n * 3) - 3) / 2));
        Console.Write("x|x");
        Console.Write(new string('.', ((n * 3) - 3) / 2));
        Console.WriteLine();
        Console.Write(new string('.', ((n * 3) - 3) / 2));
        Console.Write(@"\x/");
        Console.Write(new string('.', ((n * 3) - 3) / 2));
        Console.WriteLine();
        Console.Write(new string('.', ((n * 3) - 1) / 2));
        Console.Write(new string('x', 1));
        Console.Write(new string('.', ((n * 3) - 1) / 2));
        Console.WriteLine();
    }
}
