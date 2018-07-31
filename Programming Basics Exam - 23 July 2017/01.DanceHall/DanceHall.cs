using System;

public class DanceHall
{
    public static void Main()
    {
        double L = double.Parse(Console.ReadLine());
        double W = double.Parse(Console.ReadLine());
        double A = double.Parse(Console.ReadLine());

        double roomSize = (L * 100) * (W * 100);
        double wardrobeSize = (A * 100) * (A * 100);
        double sizeOfBench = roomSize / 10;
        double freeSpace = roomSize - wardrobeSize - sizeOfBench;
        double numberOfDancers = freeSpace / (40 + 7000);

        Console.WriteLine(Math.Floor(numberOfDancers));
    }
}