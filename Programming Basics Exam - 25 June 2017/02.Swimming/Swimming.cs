using System;

public class Swimming
{
    public static void Main()
    {
        double secRecord = double.Parse(Console.ReadLine());
        double distance = double.Parse(Console.ReadLine());
        double timeForOneMeter = double.Parse(Console.ReadLine());

        double swims = distance * timeForOneMeter;
        double bonusTime = Math.Floor(distance / 15) * 12.5;
        double totalTime = swims + bonusTime;

        if (secRecord <= totalTime)
        {
            double nedostigashtiSek = totalTime - secRecord;
            Console.WriteLine($"No, he failed! He was {nedostigashtiSek:F2} seconds slower.");
        }
        else
        {
            Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
        }
    }
}