using System;

class CurrencyConverter
{
    public static void Main()
    {       
        double money = double.Parse(Console.ReadLine());
        string incomingCurrency = Console.ReadLine();
        string outcomintCurrency = Console.ReadLine();

        if (incomingCurrency == "BGN" && outcomintCurrency == "USD")
        {
            Console.WriteLine("{0} USD", Math.Round((money / 1.79549), 2));
        }
        else if (incomingCurrency == "BGN" && outcomintCurrency == "EUR")
        {
            Console.WriteLine("{0} EUR", Math.Round((money / 1.95583), 2));
        }
        else if (incomingCurrency == "BGN" && outcomintCurrency == "GBP")
        {
            Console.WriteLine("{0} GBP", Math.Round((money / 2.53405), 2));
        }
        else if (incomingCurrency == "USD" && outcomintCurrency == "BGN")
        {
            Console.WriteLine("{0} BGN", Math.Round((money * 1.79549), 2));
        }
        else if (incomingCurrency == "USD" && outcomintCurrency == "EUR")
        {
            Console.WriteLine("{0} EUR", Math.Round(((money * 1.79549) / 1.95583), 2));
        }
        else if (incomingCurrency == "USD" && outcomintCurrency == "GBP")
        {
            Console.WriteLine("{0} GBP", Math.Round(((money * 1.79549) / 2.53405), 2));
        }
        else if (incomingCurrency == "EUR" && outcomintCurrency == "USD")
        {
            Console.WriteLine("{0} USD", Math.Round(((money * 1.95583) / 1.79549), 2));
        }
        else if (incomingCurrency == "EUR" && outcomintCurrency == "BGN")
        {
            Console.WriteLine("{0} BGN", Math.Round((money * 1.95583), 2));
        }
        else if (incomingCurrency == "EUR" && outcomintCurrency == "GBP")
        {
            Console.WriteLine("{0} GBP", Math.Round(((money * 1.95583) / 2.53405), 2));
        }
        else if (incomingCurrency == "GBP" && outcomintCurrency == "USD")
        {
            Console.WriteLine("{0} USD", Math.Round(((money * 2.53405) / 1.79549), 2));
        }
        else if (incomingCurrency == "GBP" && outcomintCurrency == "EUR")
        {
            Console.WriteLine("{0} EUR", Math.Round(((money * 2.53405) / 1.95583), 2));
        }
        else if (incomingCurrency == "GBP" && outcomintCurrency == "BGN")
        {
            Console.WriteLine("{0} BGN", Math.Round((money * 2.53405), 2));
        }
    }
}
