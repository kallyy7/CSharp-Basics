using System;

public class BarcodeGenerator
{
    public static void Main()
    {
        int begin = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());

        int a = begin % 10;
        begin /= 10;
        int b = begin % 10;
        begin /= 10;
        int c = begin % 10;
        begin /= 10;
        int d = begin % 10;

        int aa = end % 10;
        end /= 10;
        int bb = end % 10;
        end /= 10;
        int cc = end % 10;
        end /= 10;
        int dd = end % 10;


        for (int num1 = d; num1 <= dd; num1++)
        {
            for (int num2 = c; num2 <= cc; num2++)
            {
                for (int num3 = b; num3 <= bb; num3++)
                {
                    for (int num4 = a; num4 <= aa; num4++)
                    {
                        if (num1 % 2 != 0 && num2 % 2 != 0 && num3 % 2 != 0 && num4 % 2 != 0)
                        {
                            Console.Write("{0}{1}{2}{3} ", num1, num2, num3, num4);
                        }
                    }
                }
            }
        }
    }
}