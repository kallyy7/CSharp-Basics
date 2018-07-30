using System;

class BonusScore
{
    public static void Main()
    {
        Console.Write("Enter score:");
        double number = double.Parse(Console.ReadLine());

        if (number <= 100 && number % 2 == 0)
        {
            Console.WriteLine("Bonus score: " + (5 + 1));
            Console.WriteLine("Total score: " + (number + 5 + 1));

        }
        else if (number <= 100 && number % 5 == 0)
        {
            Console.WriteLine("Bonus score: " + (5 + 2));
            Console.WriteLine("Total score: " + (number + 5 + 2));

        }
        else if (number <= 100)
        {
            Console.WriteLine("Bonus score: " + 5);
            Console.WriteLine("Total score: " + (number + 5));
        }
        else if (number > 1000 && number % 2 == 0)
        {
            Console.WriteLine("Bonus score: " + ((number * 10 / 100) + 1));
            Console.WriteLine("Total score: " + (number + (number * 10 / 100) + 1));
        }
        else if (number > 1000 && number % 5 == 0)
        {
            Console.WriteLine("Bonus score: " + ((number * 10 / 100) + 2));
            Console.WriteLine("Total score: " + (number + (number * 10 / 100) + 2));
        }
        else if (number > 1000)
        {
            Console.WriteLine("Bonus score: " + (number * 10 / 100));
            Console.WriteLine("Total score: " + (number + (number * 10 / 100)));
        }
        else if (number > 100 && number % 2 == 0)
        {
            Console.WriteLine("Bonus score: " + ((number * 20 / 100) + 1));
            Console.WriteLine("Total score: " + (number + (number * 20 / 100) + 1));
        }
        else if (number > 100 && number % 5 == 0)
        {
            Console.WriteLine("Bonus score: " + ((number * 20 / 100) + 2));
            Console.WriteLine("Total score: " + (number + (number * 20 / 100) + 2));
        }
        else if (number > 100)
        {
            Console.WriteLine("Bonus score: " + (number * 20 / 100));
            Console.WriteLine("Total score: " + (number + (number * 20 / 100)));
        }
    }
}
