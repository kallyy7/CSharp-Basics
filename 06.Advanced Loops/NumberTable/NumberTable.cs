using System;

class NumberTable
{
    public static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());

        for (int row = 0; row < inputNumber; row++)
        {
            for (int col = 1 + row; col <= inputNumber + row; col++)
            {
                if (col > inputNumber)
                {
                    Console.Write(2 * inputNumber - col + " ");
                }
                else
                {
                    Console.Write(col + " ");
                }
            }

            Console.WriteLine();
        }
    }
}
