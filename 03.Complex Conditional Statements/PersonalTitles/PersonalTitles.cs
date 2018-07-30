using System;

class PersonalTitles
{
    public static void Main()
    {
        double age = double.Parse(Console.ReadLine());
        string gender = Console.ReadLine();
        string title = null;

        if (age < 16 && gender == "f")
        {
            title = "Miss";
        }
        else if (age < 16 && gender == "m")
        {
            title = "Master";
        }
        else if (age >= 16 && gender == "f")
        {
            title = "Ms.";
        }
        else if (age >= 16 && gender == "m")
        {
            title = "Mr.";
        }

        Console.WriteLine(title);
    }
}

