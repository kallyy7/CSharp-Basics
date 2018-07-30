using System;

class OddEvenPosition
{
    public static void Main()
    {
        double inputNumber = double.Parse(Console.ReadLine());
        double oddSum = 0;
        double oddMin = double.MaxValue;
        double oddMax = double.MinValue;
        double evenSum = 0;
        double evenMin = double.MaxValue;
        double evenMax = double.MinValue;

        for (int i = 1; i <= inputNumber; i++)
        {
            double currentNumber = double.Parse(Console.ReadLine());

            if (i % 2 == 0)
            {
                evenSum += currentNumber;

                if (currentNumber < evenMin)
                {
                    evenMin = currentNumber;
                }
                else if (currentNumber > evenMax)
                {
                    evenMax = currentNumber;
                }
            }

            else
            {

                oddSum += currentNumber;

                if (currentNumber < oddMin)
                {
                    oddMin = currentNumber;
                }
                else if (currentNumber > oddMax)
                {
                    oddMax = currentNumber;
                }
            }

        }

        Console.WriteLine("OddSum = " + oddSum);

        if (oddMin == double.MaxValue)
        {
            Console.WriteLine("OddMin = No");
        }
        else
        {
            Console.WriteLine("OddMin = " + oddMin);
        }

        if (oddMax == double.MinValue)
        {
            Console.WriteLine("OddMax = No");
        }
        else
        {
            Console.WriteLine("OddMax = " + oddMax);
        }

        Console.WriteLine("EvenSum = " + evenSum);

        if (evenMin == double.MaxValue)
        {
            Console.WriteLine("EvenMin = No");
        }
        else
        {
            Console.WriteLine("EvenMin = " + evenMin);
        }

        if (evenMax == double.MinValue)
        {
            Console.WriteLine("EvenMax = No");
        }
        else
        {
            Console.WriteLine("EvenMax = " + evenMax);
        }
    }
}
