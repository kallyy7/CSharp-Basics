using System;

class Diamond
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int mid = -1;

        if (number % 2 == 0)
        {
            mid = 0;
        }

        for (int row = 1; row <= (number + 1) / 2; row++)
        {
            int left = (number - 2 - mid) / 2;

            Console.Write(new string('-', left));
            Console.Write("*");

            if (mid >= 0)
            {
                Console.Write(new string('-', mid));
                Console.Write("*");
            }

            Console.Write(new string('-', left));
            Console.WriteLine();

            mid = mid + 2;
        }
        mid = number - 4;

        for (int row = 1; row < (number + 1) / 2; row++)
        {
            int left = (number - 2 - mid) / 2;

            Console.Write(new string('-', left));
            Console.Write("*");

            if (mid >= 0)
            {
                Console.Write(new string('-', mid));
                Console.Write("*");
            }

            Console.Write(new string('-', left));
            Console.WriteLine();

            mid = mid - 2;

        }
    }
}
