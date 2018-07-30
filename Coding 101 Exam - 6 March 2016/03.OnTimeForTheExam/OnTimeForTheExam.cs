using System;

class OnTimeForTheExam
{
    public static void Main()
    {
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());
        int hourArrivedTime = int.Parse(Console.ReadLine());
        int minutesArrivedTime = int.Parse(Console.ReadLine());

        int examTime = (hours * 60) + minutes;
        int arrivedTime = (hourArrivedTime * 60) + minutesArrivedTime;
        int diff = Math.Abs(examTime - arrivedTime);

        if (examTime == arrivedTime)
        {
            Console.WriteLine("On time");
        }
        else if (examTime < arrivedTime)
        {
            Console.WriteLine("Late");
            if (diff >= 60)
            {
                int ch = diff / 60;
                int min = diff % 60;

                if (min < 10)
                {
                    Console.WriteLine($"{ch}:0{min} hours after the start");
                }
                else
                {
                    Console.WriteLine($"{ch}:{min} hours after the start");
                }
            }
            else
            {
                Console.WriteLine("{0} minutes after the start", diff);
            }
        }
        else if (examTime > arrivedTime && diff <= 30)
        {
            Console.WriteLine("On time");
            Console.WriteLine("{0} minutes before the start", diff);
        }
        else if (examTime > arrivedTime && diff > 30)
        {
            Console.WriteLine("Early");

            if (diff >= 60)
            {
                int ch = diff / 60;
                int min = diff % 60;

                if (min < 10)
                {
                    Console.WriteLine($"{ch}:0{min} hours before the start");
                }
                else
                {
                    Console.WriteLine($"{ch}:{min} hours before the start");
                }
            }
            else
            {
                Console.WriteLine("{0} minutes before the start", diff);
            }
        }
    }
}
