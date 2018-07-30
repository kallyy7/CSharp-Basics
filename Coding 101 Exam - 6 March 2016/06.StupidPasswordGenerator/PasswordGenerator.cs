using System;

class PasswordGenerator
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int l = int.Parse(Console.ReadLine());


        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                for (int k = 97; k < 97 + l; k++)
                {
                    for (int o = 97; o < 97 + l; o++)
                    {
                        for (int m = 1; m <= n; m++)
                        {
                            if (m > i && m > j)
                            {
                                Console.Write("{0}{1}{2}{3}{4} ", i, j, (char)k, (char)o, m);
                            }
                        }
                    }
                }
            }
        }
    }
}
