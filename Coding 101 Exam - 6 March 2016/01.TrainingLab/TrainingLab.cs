using System;

class TrainingLab
{
    public static void Main()
    {
        double w = Math.Floor((double.Parse(Console.ReadLine()) * 100) / 120);
        double h = Math.Floor((double.Parse(Console.ReadLine()) * 100 - 100) / 70);

        Console.WriteLine(w * h - 3);
    }
}
