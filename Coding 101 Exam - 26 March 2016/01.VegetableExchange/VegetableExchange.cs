using System;

class VegetableExchange
{
    public static void Main()
    {
        double kgVeggies = double.Parse(Console.ReadLine());
        double kgFruits = double.Parse(Console.ReadLine());
        int totalKgVeggies = int.Parse(Console.ReadLine());
        int totalKgFruits = int.Parse(Console.ReadLine());

        double veggies = kgVeggies * totalKgVeggies;
        double fruits = kgFruits * totalKgFruits;
        double total = (veggies + fruits) / 1.94;

        Console.WriteLine(total);
    }
}
