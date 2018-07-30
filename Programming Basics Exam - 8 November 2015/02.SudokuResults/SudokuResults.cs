using System;

public class SudokuResults
{
    public static void Main()
    {
        int minutes = 0;
        int seconds = 0;
        double total = 0;
        double counter = 0;
        string star = null;

        while (true)
        {
            string time = Console.ReadLine();

            try
            {
                minutes = int.Parse(time.Substring(0, 2));
                seconds = int.Parse(time.Substring(3, 2));
            }
            catch
            {
                break;
            }

            total = total + minutes * 60 + seconds;
            counter += 1;
        }

        total = Math.Ceiling(total / counter);

        if (total < 720)
        {
            star += "Gold Star";
        }
        else if (total < 1440)
        {
            star += "Silver Star";
        }
        else if (total > 1440)
        {
            star += "Bronze Star";
        }

        Console.WriteLine($"{star}");
        Console.WriteLine($"Games - {counter} \\ Average seconds - {total}");
    }
}