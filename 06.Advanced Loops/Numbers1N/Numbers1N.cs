using System;

class Numbers1N
{
    public static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());

        for (int i = inputNumber; i >= 1; i--)
        {
            Console.WriteLine(i);
        }
    }
}
