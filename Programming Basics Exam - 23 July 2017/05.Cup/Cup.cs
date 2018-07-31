using System;

public class Cup
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int width = 5 * n;
        int hashtag = n * 3;
        int dots = n;
        int vdots = 0;
        int body = (width - (n + 4)) / 2;

        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine($@"{new string('.', dots)}{new string('#', hashtag)}{new string('.', dots)}");
            hashtag -= 2;
            dots += 1;
        }
        vdots = hashtag - 2;

        for (int i = 0; i < (n / 2) + 1; i++)
        {
            Console.WriteLine($@"{new string('.', dots)}#{new string('.', vdots)}#{new string('.', dots)}");
            dots += 1;
            vdots -= 2;
        }
        Console.WriteLine($@"{new string('.', (4 * n) / 2)}{new string('#', n)}{new string('.', (4 * n) / 2)}");

        for (int i = 0; i < (n / 2); i++)
        {
            Console.WriteLine($@"{new string('.', body)}{new string('#', n + 4)}{new string('.', body)}");
        }
        Console.WriteLine($@"{new string('.', (width - 10) / 2)}D^A^N^C^E^{new string('.', (width - 10) / 2)}");

        for (int i = 0; i < (n / 2) + 1; i++)
        {
            Console.WriteLine($@"{new string('.', body)}{new string('#', n + 4)}{new string('.', body)}");
        }
    }
}