using System;

class EqualPairs
{
    public static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());
        int sum = 0;
        int commonValue = 0;
        int max = int.MinValue;
        int min = int.MaxValue;

        for (int i = 0; i < inputNumber; i++)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber + secondNumber < min)
            {
                min = firstNumber + secondNumber;
            }
            else if (firstNumber + secondNumber > max)
            {
                max = firstNumber + secondNumber;
            }
            else if (firstNumber + secondNumber == sum)
            {
                commonValue = firstNumber + secondNumber;
            }

            sum += firstNumber + secondNumber;
        }
        if (inputNumber == 1)
        {
            Console.WriteLine("Yes, value={0}", sum);
        }
        else if (commonValue != 0)
        {
            Console.WriteLine("Yes, value={0}", commonValue);
        }
        else
        {
            double maxDiff = max - min;
            Console.WriteLine("No, maxdiff={0}", maxDiff);
        }
    }
}
