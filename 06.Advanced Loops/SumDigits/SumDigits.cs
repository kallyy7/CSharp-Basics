using System;

class SumDigits
{
    public static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());
        int sum = 0;

        do
        {
            sum = sum + (inputNumber % 10);
            inputNumber = inputNumber / 10;

        } while (inputNumber > 0);

        Console.WriteLine(sum);
    }
}
