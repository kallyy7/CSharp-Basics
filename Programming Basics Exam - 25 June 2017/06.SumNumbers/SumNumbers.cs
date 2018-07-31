using System;

public class SumNumbers
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int sum = 0;
        int counter = 0;

        for (int a = 1; a <= 30; a++)
        {
            for (int b = 1; b <= 30; b++)
            {
                for (int c = 1; c <= 30; c++)
                {
                    if ((a < b && b < c) && (a + b + c) == n)
                    {
                        Console.WriteLine($"{a} + {b} + {c} = {n}");
                        sum += 1;
                    }
                    else if ((a > b && b > c) && (a * b * c) == n)
                    {
                        Console.WriteLine($"{a} * {b} * {c} = {n}");
                        counter += 1;
                    }
                }
            }
        }

        if (sum == 0 && counter == 0)
        {
            Console.WriteLine("No!");
        }
    }
}