using System;

class NumbersWithStep3
{
    public static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());

        for (int i = 1; i <= inputNumber; i += 3)
        {
            Console.WriteLine(i);
        }
    }
}
