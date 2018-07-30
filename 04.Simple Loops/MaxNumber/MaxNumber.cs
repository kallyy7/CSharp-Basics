using System;

class MaxNumber
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int max = int.MinValue;

        for (int i = 0; i < number; i++)
        {
            int current = int.Parse(Console.ReadLine());

            if (current > max)
            {
                max = current;
            }
        }
        Console.WriteLine(max);

    }
}
