using System;

class Sequence2kPlus1
{
    public static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());
        int sum = 1;

        for (int i = 0; i <= inputNumber; i += 3)
        {
            if (sum <= inputNumber)
            {
                Console.WriteLine(sum);
            }
            
            sum = (sum * 2) + 1;
        }
    }
}
