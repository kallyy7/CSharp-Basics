using System;

class House
{
    public static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());
        int stars = 1;

        if (inputNumber % 2 == 0)
        {
            stars = 2;
        }

        if (inputNumber >= 2 && inputNumber < 100)
        {
            for (int row = 1; row <= (inputNumber + 1) / 2; row++)
            {
                int hyphenMinus = (inputNumber - stars) / 2;
                Console.Write(new string('-', hyphenMinus));
                Console.Write(new string('*', stars));
                Console.Write(new string('-', hyphenMinus));
                Console.WriteLine();
                stars = stars + 2;
            }

            int houseBase = inputNumber / 2;

            for (int row = 0; row < houseBase; row++)
            {
                stars = inputNumber - 2;
                Console.Write("|");
                Console.Write(new string('*', stars));
                Console.Write("|");
                Console.WriteLine();
            }
        }
    }
}
