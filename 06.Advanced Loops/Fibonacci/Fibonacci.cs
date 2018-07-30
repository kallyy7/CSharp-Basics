using System;

class Fibonacci
{
    public static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());
        int f0 = 1;
        int f1 = 1;

        for (int i = 0; i < inputNumber - 1; i++)
        {
            int sum = f0 + f1;
            f0 = f1;
            f1 = sum;
        }

        Console.WriteLine(f1);
    }
}
