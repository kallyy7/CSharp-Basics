using System;

class EnterEvenNumber
{
    public static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());

        while (inputNumber % 2 != 0)
        {
            Console.WriteLine("The number is not even.");
            inputNumber = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Even number entered: " + inputNumber);
    }
}
