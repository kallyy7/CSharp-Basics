using System;

class OddEvenSum
{
    public static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());
        int evenNumber = 0;
        int oddNumber = 0;

        for (int i = 0; i < inputNumber; i++)
        {
            int rightSum = int.Parse(Console.ReadLine());

            if (i % 2 == 0)
            {
                evenNumber += rightSum;
            }
            else
            {
                oddNumber += rightSum;
            }
        }

        if (evenNumber == oddNumber)
        {
            Console.WriteLine("yes sum " + evenNumber);
        }
        else
        {
            int difference = Math.Abs(evenNumber - oddNumber);
            Console.WriteLine("no diff " + difference);
        }
    }
}
