using System;

class NumberInRangeFrom1To100
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        while (number < 1 || number > 100)
        {
            Console.WriteLine("Invalid number!");
            number = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("The number is: " + number);
    }
}
