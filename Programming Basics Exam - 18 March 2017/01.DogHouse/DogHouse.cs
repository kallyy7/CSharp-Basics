using System;

public class DogHouse
{
    public static void Main()
    {
        double A = double.Parse(Console.ReadLine());
        double B = double.Parse(Console.ReadLine());

        double bothWalls = A * (A / 2) * 2;
        double backWall = ((A / 2) * (A / 2)) + (((A / 2) * (B - (A / 2)) / 2));
        double door = (A / 5) * (A / 5);
        double frontWall = backWall - door;
        double totalAreaOfWalls = bothWalls + backWall + frontWall;
        double greenPaint = totalAreaOfWalls / 3;
        double roof = A * (A / 2) * 2;
        double redPaint = roof / 5;

        Console.WriteLine($"{greenPaint:F2}");
        Console.WriteLine($"{redPaint:F2}");
    }
}