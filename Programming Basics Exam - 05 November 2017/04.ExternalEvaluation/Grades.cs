using System;

public class Grades
{
    public static void Main(string[] args)
    {
        int numberStudents = int.Parse(Console.ReadLine());
        double poorMark = 0;
        double satisfactoryMark = 0;
        double goodMark = 0;
        double veryGoodMark = 0;
        double excellentMark = 0;

        for (int i = 1; i <= numberStudents; i++)
        {
            double numberPoints = double.Parse(Console.ReadLine());
            if (numberPoints >= 0 && numberPoints <= 22.5)
            {
                poorMark += 1;
            }
            else if (numberPoints > 22.5 && numberPoints <= 40.5)
            {
                satisfactoryMark += 1;
            }
            else if (numberPoints > 40.5 && numberPoints <= 58.5)
            {
                goodMark += 1;
            }
            else if (numberPoints > 58.5 && numberPoints <= 76.5)
            {
                veryGoodMark += 1;
            }
            else if (numberPoints > 76.5 && numberPoints <= 100)
            {
                excellentMark += 1;
            }
        }

        poorMark = poorMark / numberStudents * 100;
        satisfactoryMark = satisfactoryMark / numberStudents * 100;
        goodMark = goodMark / numberStudents * 100;
        veryGoodMark = veryGoodMark / numberStudents * 100;
        excellentMark = excellentMark / numberStudents * 100;

        Console.WriteLine($"{poorMark:F2}% poor marks");
        Console.WriteLine($"{satisfactoryMark:F2}% satisfactory marks");
        Console.WriteLine($"{goodMark:F2}% good marks");
        Console.WriteLine($"{veryGoodMark:F2}% very good marks");
        Console.WriteLine($"{excellentMark:F2}% excellent marks");
    }
}