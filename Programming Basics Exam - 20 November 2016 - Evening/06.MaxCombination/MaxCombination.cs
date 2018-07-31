using System;

public class MaxCombination
{
    public static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        int maxNumbers = int.Parse(Console.ReadLine());
        int sum = 0;

        for (int a = start; a <= end; a++)
        {
            for (int b = start; b <= end; b++)
            {
                Console.Write($"<{a}-{b}>");
                sum += 1;

                if (sum == maxNumbers)
                {
                    return;
                }
            }
        }
    }
}