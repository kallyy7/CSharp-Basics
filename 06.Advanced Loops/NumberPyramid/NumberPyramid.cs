using System;

class NumberPyramid
{
    static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());
        int num = 1;

        for (int row = 1; row <= inputNumber; row++)
        {
            for (int col = 1; col <= row; col++)
            {
                if (col > 1)
                {
                    Console.Write(" ");
                }

                Console.Write(num);
                num++;

                if (num > inputNumber)
                {
                    break;
                }
            }

            Console.WriteLine();

            if (num > inputNumber)
            {
                break;
            }
        }
    }
}
