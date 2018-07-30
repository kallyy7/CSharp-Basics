using System;

public class Lutenitsa
{
    public static void Main()
    {
        double tomato = double.Parse(Console.ReadLine());
        int numberOfBoxes = int.Parse(Console.ReadLine());
        int numberOfJars = int.Parse(Console.ReadLine());

        double totalLutenitsaKg = tomato / 5;
        double jars = totalLutenitsaKg / 0.535;
        double boxes = jars / numberOfJars;

        Console.WriteLine("Total lutenica: {0} kilograms.", Math.Floor(totalLutenitsaKg));

        if (boxes >= numberOfBoxes)
        {
            double leftBoxes = boxes - numberOfBoxes;
            double leftJars = jars - (numberOfBoxes * numberOfJars);

            Console.WriteLine("{0} boxes left.", Math.Floor(leftBoxes));
            Console.WriteLine("{0} jars left.", Math.Floor(leftJars));
        }
        else
        {
            double boxesNeeded = numberOfBoxes - boxes;
            double jarsNeeded = (numberOfBoxes * numberOfJars) - jars;

            Console.WriteLine("{0} more boxes needed.", Math.Floor(boxesNeeded));
            Console.WriteLine("{0} more jars needed.", Math.Floor(jarsNeeded));
        }
    }
}