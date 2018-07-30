using System;

class RectangleOfStars
{
    static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());

        for (int i = 0; i < inputNumber; i++)
        {
            Console.WriteLine(new string('*', inputNumber));
        }
    }
}
