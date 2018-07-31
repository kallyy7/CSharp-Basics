using System;

public class EncodedAnswers
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int A = 0;
        int B = 0;
        int C = 0;
        int D = 0;
        string questAnswers = null;

        for (int i = 1; i <= n; i++)
        {
            int answers = int.Parse(Console.ReadLine());

            if (answers % 4 == 0)
            {
                A += 1;
                questAnswers += "a ";
            }
            else if (answers % 4 == 1)
            {
                B += 1;
                questAnswers += "b ";
            }
            else if (answers % 4 == 2)
            {
                C += 1;
                questAnswers += "c ";
            }
            else if (answers % 4 == 3)
            {
                D += 1;
                questAnswers += "d ";
            }
        }

        Console.WriteLine(questAnswers);
        Console.WriteLine($"Answer A: {A}");
        Console.WriteLine($"Answer B: {B}");
        Console.WriteLine($"Answer C: {C}");
        Console.WriteLine($"Answer D: {D}");
    }
}