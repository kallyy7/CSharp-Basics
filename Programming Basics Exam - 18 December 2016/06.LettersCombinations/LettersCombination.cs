using System;

public class LettersCombination
{
    public static void Main()
    {
        string first = Console.ReadLine();
        string second = Console.ReadLine();
        string no = Console.ReadLine();

        char firstLetter = first.ToCharArray();
        char secondLetters = second.ToCharArray();
        char noLetter = no.ToCharArray();
        int sum = 0;

        for (char a = firstLetter; a <= secondLetters; a++)
        {
            for (char b = firstLetter; b <= secondLetters; b++)
            {
                for (char c = firstLetter; c <= secondLetters; c++)
                {
                    if (a != noLetter && b != noLetter && c != noLetter)
                    {
                        sum += 1;
                        Console.Write($"{a}{b}{c} ");
                    }
                }
            }
        }

        Console.WriteLine(sum);
    }
}