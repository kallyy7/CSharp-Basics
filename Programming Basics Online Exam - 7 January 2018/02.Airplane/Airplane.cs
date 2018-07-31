using System;

public class Airplane
{
    public static void Main()
    {
        int hour = int.Parse(Console.ReadLine());
        int minute = int.Parse(Console.ReadLine());
        int flight = int.Parse(Console.ReadLine());

        int time = (hour * 60) + minute;
        int arrival = time + flight;
        int minTime = arrival % 60;
        int hourTime = arrival / 60;

        if (hourTime >= 24)
        {
            hourTime -= 24;
        }

        Console.WriteLine($"{hourTime}h {minTime}m");
    }
}