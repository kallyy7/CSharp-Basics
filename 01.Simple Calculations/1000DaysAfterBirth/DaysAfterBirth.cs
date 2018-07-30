using System;

public class DaysAfterBirth
{
    public static void Main()
    {
        string format = "dd-MM-yyyy";
        string data = Console.ReadLine();

        DateTime userDate = DateTime.ParseExact(data, format, null);

        Console.WriteLine(userDate.AddDays(999).ToString("dd-MM-yyyy"));
    }
}