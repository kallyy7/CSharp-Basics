using System;

public class PhotoPictures
{
    public static void Main()
    {
        int nPhotos = int.Parse(Console.ReadLine());
        string kindOfPhotos = Console.ReadLine();
        string kindOfOrder = Console.ReadLine();
        double singlePrice = 0;
        double total = 0;

        switch (kindOfPhotos)
        {
            case "9X13":
                singlePrice = 0.16;
                total = singlePrice * nPhotos;

                if (nPhotos >= 50)
                {
                    total *= 0.95;
                }
                break;
            case "10X15":
                singlePrice = 0.16;
                total = singlePrice * nPhotos;

                if (nPhotos >= 80)
                {
                    total *= 0.97;
                }
                break;
            case "13X18":
                singlePrice = 0.38;
                total = singlePrice * nPhotos;

                if (nPhotos >= 50 && nPhotos <= 100)
                {
                    total *= 0.97;
                }
                else if (nPhotos > 100)
                {
                    total *= 0.95;
                }
                break;
            case "20X30":
                singlePrice = 2.90;
                total = singlePrice * nPhotos;

                if (nPhotos >= 10 && nPhotos <= 50)
                {
                    total *= 0.93;
                }
                else if (nPhotos > 50)
                {
                    total *= 0.91;
                }
                break;
        }

        if (kindOfOrder == "online")
        {
            total *= 0.98;
        }

        Console.WriteLine($"{total:F2}BGN");
    }
}