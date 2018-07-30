using System;

class EvenPowerOf2
{
    public static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());
        int sum = 1;

        for (int i = 0; i <= inputNumber; i += 2)
        {
            if (sum % 4 == 0 || sum == 1)
            {
                Console.WriteLine(sum);
            }

            sum *= 4;           
        }
    }
}
