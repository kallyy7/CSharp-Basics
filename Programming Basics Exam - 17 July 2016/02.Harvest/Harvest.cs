using System;

public class Harvest
{
    public static void Main()
    {
        int vineyard = int.Parse(Console.ReadLine());
        double grape = double.Parse(Console.ReadLine());
        int literWine = int.Parse(Console.ReadLine());
        int workers = int.Parse(Console.ReadLine());

        double totalGrape = vineyard * grape;
        double wine = (totalGrape * 0.4) / 2.5;

        if (wine >= literWine)
        {
            double left = Math.Ceiling(wine - literWine);
            double forPerson = Math.Ceiling(left / workers);
            Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(wine));
            Console.WriteLine("{0} liters left -> {1} liters per person.", left, forPerson);
        }
        else
        {
            double needed = Math.Floor(literWine - wine);
            Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", needed);
        }
    }
}