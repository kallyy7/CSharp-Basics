using System;

class CheckPrime
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        bool prime = true;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                prime = false;
                break;
            }
        }

        if (number < 2)
        {
            Console.WriteLine("Not prime");
        }
        else if (prime)
        {
            Console.WriteLine("Prime");
        }
        else
        {
            Console.WriteLine("Not prime");
        }
    }
}
