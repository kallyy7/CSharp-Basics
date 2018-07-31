using System;

public class StudentCables
{
    public static void Main()
    {
        int numberOfCables = int.Parse(Console.ReadLine());

        int totalLenght = 0;
        int counter = numberOfCables;

        for (int i = 1; i <= numberOfCables; i++)
        {
            int cableLenght = int.Parse(Console.ReadLine());
            string measure = Console.ReadLine();

            if (measure == "meters")
            {
                cableLenght *= 100;
            }
            if (cableLenght < 20)
            {
                cableLenght = 0;
                counter--;
            }
            totalLenght += cableLenght;
        }
        totalLenght = totalLenght - (counter - 1) * 3;

        Console.WriteLine(totalLenght / 504);
        Console.WriteLine(totalLenght % 504);
    }
}