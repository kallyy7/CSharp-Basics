using System;

public class Scholarship
{
    public static void Main()
    {
        double incomeBGN = double.Parse(Console.ReadLine());
        double averageSuccess = double.Parse(Console.ReadLine());
        double minSalary = double.Parse(Console.ReadLine());

        if (incomeBGN < minSalary && averageSuccess >= 5.50)
        {
            double socialScholarship = minSalary * 0.35;
            double scholarship = averageSuccess * 25;

            if (socialScholarship > scholarship)
            {
                Console.WriteLine("You get a Social scholarship {0} BGN", Math.Floor(socialScholarship));
            }
            else
            {
                Console.WriteLine("You get a scholarship for excellent results {0} BGN", Math.Floor(scholarship));
            }
        }
        else if (incomeBGN < minSalary && averageSuccess >= 4.50)
        {
            double socStipendiq = minSalary * 0.35;

            Console.WriteLine("You get a Social scholarship {0} BGN", Math.Floor(socStipendiq));
        }
        else if (averageSuccess >= 5.50)
        {
            double uspehStipendiq = averageSuccess * 25;

            Console.WriteLine("You get a scholarship for excellent results {0} BGN", Math.Floor(uspehStipendiq));
        }
        else
        {
            Console.WriteLine("You cannot get a scholarship!");
        }
    }
}