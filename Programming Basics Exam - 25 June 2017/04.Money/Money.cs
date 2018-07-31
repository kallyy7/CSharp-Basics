using System;

public class Money
{
    public static void Main()
    {
        int parts = int.Parse(Console.ReadLine());
        double priceForOnePoint = double.Parse(Console.ReadLine());

        double price = 0;
        double money = 0;

        for (int i = 1; i <= parts; i++)
        {
            double points = double.Parse(Console.ReadLine());

            if (i % 2 == 0 && i != 1)
            {
                double sum = points * 2;
                price += sum;
            }
            else
            {
                price += points;
            }
        }
        money = priceForOnePoint * price;

        Console.WriteLine($"The project prize was {money:F2} lv.");
    }
}