using System;

class Program
{
    public static void Main()
    {
        string city = Console.ReadLine();
        double sales = double.Parse(Console.ReadLine());

        if (city == "Sofia")
        {
            if (sales >= 0 && sales <= 500)
            {
                Console.WriteLine(sales * 5 / 100);
            }
            else if (sales > 500 && sales <= 1000)
            {
                Console.WriteLine(sales * 7 / 100);
            }
            else if (sales > 1000 && sales <= 10000)
            {
                Console.WriteLine(sales * 8 / 100);
            }
            else if (sales > 10000)
            {
                Console.WriteLine(sales * 12 / 100);
            }
        }
        else if (city == "Varna")
        {
            if (sales >= 0 && sales <= 500)
            {
                Console.WriteLine(sales * 4.5 / 100);
            }
            else if (sales > 500 && sales <= 1000)
            {
                Console.WriteLine(sales * 7.5 / 100);
            }
            else if (sales > 1000 && sales <= 10000)
            {
                Console.WriteLine(sales * 10 / 100);
            }
            else if (sales > 10000)
            {
                Console.WriteLine(sales * 13 / 100);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        else if (city == "Plovdiv")
        {
            if (sales >= 0 && sales <= 500)
            {
                Console.WriteLine(sales * 5.5 / 100);
            }
            else if (sales > 500 && sales <= 1000)
            {
                Console.WriteLine(sales * 8 / 100);
            }
            else if (sales > 1000 && sales <= 10000)
            {
                Console.WriteLine(sales * 12 / 100);
            }
            else if (sales > 10000)
            {
                Console.WriteLine(sales * 14.5 / 100);
            }
            else
            {
                Console.WriteLine("error");
            }

        }
        else
        {
            Console.WriteLine("error");
        }
    }
}
