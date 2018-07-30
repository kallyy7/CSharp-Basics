using System;

class InvalidNumber
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        bool valid = number >= 100 && number <= 200 || number == 0;

        if (valid == false)
        {
            Console.WriteLine("invalid");
        } 
    }
}
