using System;

class SumNumbers
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            sum += number;
        }

        Console.WriteLine(sum);
    }
}

