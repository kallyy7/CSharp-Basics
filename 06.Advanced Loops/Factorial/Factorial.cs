using System;

class Factorial
{
    public static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());
        int sum = 1;

        for (int i = 1; i <= inputNumber; i++)
        {
            sum *= i;
        }

        Console.WriteLine(sum);
    }
}
