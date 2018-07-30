using System;

class HalfSumElement
{
    public static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());
        int sum = 0;
        int diff = 0;
        int max = int.MinValue;

        for (int i = 0; i < inputNumber; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());
            sum += currentNumber;

            if (currentNumber > max)
            {
                max = currentNumber;
            }

            diff = Math.Abs((max * 2) - sum);
        }

        if (max == (sum - max))
        {
            Console.WriteLine("Yes sum = " + max);
        }
        else
        {
            Console.WriteLine("No diff = " + diff);
        }
    }
}
