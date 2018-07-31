using System;

public class TrainersSalary
{
    public static void Main()
    {
        int lections = int.Parse(Console.ReadLine());
        double budget = double.Parse(Console.ReadLine());
        double jelev = 0;
        double royal = 0;
        double roli = 0;
        double trofon = 0;
        double sino = 0;
        double other = 0;
        double moneyPerLection = budget / lections;

        for (int i = 1; i <= lections; i++)
        {
            string trainerName = Console.ReadLine();

            if (trainerName == "Jelev")
            {
                jelev += 1;
            }
            else if (trainerName == "RoYaL")
            {
                royal += 1;
            }
            else if (trainerName == "Roli")
            {
                roli += 1;
            }
            else if (trainerName == "Trofon")
            {
                trofon += 1;
            }
            else if (trainerName == "Sino")
            {
                sino += 1;
            }
            else
            {
                other += 1;
            }
        }
        jelev *= moneyPerLection;
        royal *= moneyPerLection;
        roli *= moneyPerLection;
        trofon *= moneyPerLection;
        sino *= moneyPerLection;
        other *= moneyPerLection;

        Console.WriteLine($"Jelev salary: {jelev:F2} lv");
        Console.WriteLine($"RoYaL salary: {royal:F2} lv");
        Console.WriteLine($"Roli salary: {roli:F2} lv");
        Console.WriteLine($"Trofon salary: {trofon:F2} lv");
        Console.WriteLine($"Sino salary: {sino:F2} lv");
        Console.WriteLine($"Others salary: {other:F2} lv");
    }
}