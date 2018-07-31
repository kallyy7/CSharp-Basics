using System;

public class GroupName
{
    public static void Main()
    {
        char a = Console.ReadLine();
        char b = Console.ReadLine();
        char c = Console.ReadLine();
        char d = Console.ReadLine();
        int num = int.Parse(Console.ReadLine());

        int sum = 0;

        for (char i = 'A'; i <= a; i++)
        {
            for (char j = 'a'; j <= b; j++)
            {
                for (char k = 'a'; k <= c; k++)
                {
                    for (char o = 'a'; o <= d; o++)
                    {
                        for (int number = 0; number <= num; number++)
                        {
                            sum += 1;
                        }
                    }
                }
            }
        }

        Console.WriteLine(sum - 1);
    }
}