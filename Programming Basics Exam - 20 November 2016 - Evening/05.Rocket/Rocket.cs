using System;

public class Rocket
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int width = 3 * n;
        int dots = ((3 * n) - 2) / 2;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($@"{new string('.', dots)}/{new string(' ', i * 2)}\{new string('.', dots)}");
            dots -= 1;
        }
        dots += 1;
        int body = width - (dots * 2);
        Console.WriteLine($@"{new string('.', dots)}{new string('*', body)}{new string('.', dots)}");

        for (int i = 0; i < 2 * n; i++)
        {
            Console.WriteLine($@"{new string('.', dots)}|{new string('\\', body - 2)}|{new string('.', dots)}");
        }

        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine($@"{new string('.', dots)}/{new string('*', body - 2)}\{new string('.', dots)}");
            body += 2;
            dots -= 1;
        }
    }
}