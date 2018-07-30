using System;

public class Profit
{
    public static void Main()
    {
        int one = int.Parse(Console.ReadLine());
        int two = int.Parse(Console.ReadLine());
        int five = int.Parse(Console.ReadLine());
        int total = int.Parse(Console.ReadLine());

        for (int a = 0; a <= one; a++)
        {
            for (int b = 0; b <= two; b++)
            {
                for (int c = 0; c <= five; c++)
                {
                    int counter1lv = a * 1;
                    int counter2lv = b * 2;
                    int counter5lv = c * 5;

                    if (a <= one && b <= two && c <= five)
                    {
                        if (counter1lv + counter2lv + counter5lv == total)
                        {
                            Console.WriteLine($"{a} * 1 lv. + {b} * 2 lv. + {c} * 5 lv. = {total} lv.");
                        }
                    }
                }
            }
        }
    }
}

