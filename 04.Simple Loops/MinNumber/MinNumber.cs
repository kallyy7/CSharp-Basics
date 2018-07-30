using System;

class MinNumber
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int min = int.Parse(Console.ReadLine());

        for (int i = 0; i < number - 1; i++)
        {
            int current = int.Parse(Console.ReadLine());

            if (current < min)
            {
                min = current;
            }
        }
        Console.WriteLine(min);
    }
}
