using System;

public class Hospital
{
    public static void Main()
    {
        int daysPeriod = int.Parse(Console.ReadLine());

        int doctor = 7;
        int treated = 0;
        int untreated = 0;
        int pacient = 0;

        for (int i = 1; i <= daysPeriod; i++)
        {
            pacient = int.Parse(Console.ReadLine());

            if (i % 3 == 0 && untreated > treated)
            {
                doctor += 1;
            }

            if (pacient < doctor)
            {
                treated += pacient;
            }
            else
            {
                treated += doctor;
                untreated += pacient - doctor;
            }
        }

        Console.WriteLine("Treated patients: {0}.", treated);
        Console.WriteLine("Untreated patients: {0}.", untreated);
    }
}