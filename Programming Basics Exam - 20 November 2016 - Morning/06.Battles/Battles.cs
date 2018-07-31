using System;

public class Battles
{
    public static void Main()
    {
        int firstGamer = int.Parse(Console.ReadLine());
        int secondGamer = int.Parse(Console.ReadLine());
        int maxNumbers = int.Parse(Console.ReadLine());

        int sum = 0;

        for (int a = 1; a <= firstGamer; a++)
        {
            for (int b = 1; b <= secondGamer; b++)
            {
                Console.Write($"( {a} <-> {b} )");
                sum += 1;

                if (sum == maxNumbers)
                {
                    return;
                }
            }
        }
    }
}