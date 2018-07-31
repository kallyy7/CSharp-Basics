using System;

public class Triangle
{
    public static void Main()
    {
        decimal a = decimal.Parse(Console.ReadLine());
        decimal b = decimal.Parse(Console.ReadLine());
        decimal c = decimal.Parse(Console.ReadLine());

        if (a < a + b && b < a + c && c < a + b)
        {
            if (a == b && b == c)
            {
                Console.WriteLine("Triangle with sides {0}, {1} and {2} is equilateral.", a / 1, b / 1, c / 1);
            }
            else if (a == b)
            {
                Console.WriteLine("Triangle with sides {0}, {1} and {2} is isosceles.", a / 1, b / 1, c / 1);
            }
            else
            {
                Console.WriteLine("Triangle with sides {0}, {1} and {2} is scalene.", a / 1, b / 1, c / 1);
            }
        }
        else
        {
            Console.WriteLine("There is no triangle with sides {0}, {1} and {2}.", a / 1, b / 1, c / 1);
        }
    }
}