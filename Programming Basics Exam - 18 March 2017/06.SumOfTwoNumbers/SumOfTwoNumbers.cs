using System;

public class SumOfTwoNumbers
{
    public static void Main()
    {
        int startN = int.Parse(Console.ReadLine());
        int endN = int.Parse(Console.ReadLine());
        int magicN = int.Parse(Console.ReadLine());
        int combinations = 0;

        for (int a = startN; a <= endN; a++)
        {
            for (int b = startN; b <= endN; b++)
            {
                combinations += 1;
                if (a + b == magicN)
                {
                    Console.Write($"Combination N:{combinations} ");
                    Console.WriteLine($"({a} + {b} = {magicN})");
                    return;
                }
            }
        }

        Console.WriteLine($"{combinations} combinations - neither equals {magicN}");
    }
}
