using System;

public class SnowFlake
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int betwStars = n;
        int dots = 0;

        for (int row = 1; row <= n - 1; row++)
        {
            for (int col = 0; col < 1; col++)
            {
                Console.Write(new string('.', dots));
                Console.Write(new string('*', 1));
                Console.Write(new string('.', betwStars));
                Console.Write(new string('*', 1));
                Console.Write(new string('.', betwStars));
                Console.Write(new string('*', 1));
                Console.Write(new string('.', dots));
                dots += 1;
                betwStars -= 1;
            }
            Console.WriteLine();
        }
        Console.Write(new string('.', ((2 * n) - 2) / 2));
        Console.Write(new string('*', 5));
        Console.Write(new string('.', ((2 * n) - 2) / 2));
        Console.WriteLine();
        Console.Write(new string('*', (2 * n) + 3));
        Console.WriteLine();
        Console.Write(new string('.', ((2 * n) - 2) / 2));
        Console.Write(new string('*', 5));
        Console.Write(new string('.', ((2 * n) - 2) / 2));
        Console.WriteLine();

        dots -= 1;
        betwStars += 1;

        for (int row = 1; row <= n - 1; row++)
        {
            for (int col = 0; col < 1; col++)
            {
                Console.Write(new string('.', dots));
                Console.Write(new string('*', 1));
                Console.Write(new string('.', betwStars));
                Console.Write(new string('*', 1));
                Console.Write(new string('.', betwStars));
                Console.Write(new string('*', 1));
                Console.Write(new string('.', dots));

                dots -= 1;
                betwStars += 1;
            }

            Console.WriteLine();
        }
    }
}