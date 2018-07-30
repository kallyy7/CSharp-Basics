using System;

class MagicNumber
{
    public static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());

        for (int i = 111111; i < 1000000; i++)
        {
            int number = 1;
            int current = i;

            while (current != 0)
            {
                int digit = current % 10;
                current /= 10;
                number *= digit;
            }

            if (number == inputNumber)
            {
                Console.Write("{0} ", i);
            }
        }
    }
}
