using System;

public class Grades
{
    public static void Main()
    {
        int students = int.Parse(Console.ReadLine());
        double topStudents = 0;
        double goodGrades = 0;
        double averageGrades = 0;
        double fail = 0;
        double average = 0;
        double sum = 0;

        for (int i = 1; i <= students; i++)
        {
            double grade = double.Parse(Console.ReadLine());

            if (grade >= 5.00)
            {
                sum += grade;
                topStudents += 1;
            }
            else if (grade >= 4.00 && grade <= 4.99)
            {
                sum += grade;
                goodGrades += 1;
            }
            else if (grade >= 3.00 && grade <= 3.99)
            {
                sum += grade;
                averageGrades += 1;
            }
            else if (grade < 3.00)
            {
                sum += grade;
                fail += 1;
            }
        }
        average = sum / students;
        topStudents = topStudents / students * 100;
        goodGrades = goodGrades / students * 100;
        averageGrades = averageGrades / students * 100;
        fail = fail / students * 100;

        Console.WriteLine($"Top students: {topStudents:F2}%");
        Console.WriteLine($"Between 4.00 and 4.99: {goodGrades:F2}%");
        Console.WriteLine($"Between 3.00 and 3.99: {averageGrades:F2}%");
        Console.WriteLine($"Fail: {fail:F2}%");
        Console.WriteLine($"Average: {average:F2}");
    }
}