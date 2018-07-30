using System;

public class CourierExpress
{
    public static void Main()
    {
        double shipmentWeight = double.Parse(Console.ReadLine());
        string kindOfShipment = Console.ReadLine();
        int distance = int.Parse(Console.ReadLine());
        double price = 0;

        if (kindOfShipment == "standard")
        {
            if (shipmentWeight < 1.0)
            {
                price = distance * 0.03;
            }
            else if (shipmentWeight >= 1.0 && shipmentWeight <= 10)
            {
                price = distance * 0.05;
            }
            else if (shipmentWeight >= 11 && shipmentWeight <= 40)
            {
                price = distance * 0.10;
            }
            else if (shipmentWeight >= 41 && shipmentWeight <= 90)
            {
                price = distance * 0.15;
            }
            else if (shipmentWeight >= 91 && shipmentWeight <= 150)
            {
                price = distance * 0.20;
            }
        }
        else if (kindOfShipment == "express")
        {
            if (shipmentWeight < 1.0)
            {
                double naKM = distance * 0.03;
                double expressCena = 0.03 * 0.8;
                double nadcenka = expressCena * shipmentWeight;
                nadcenka *= distance;
                price = naKM + nadcenka; ;
            }
            else if (shipmentWeight >= 1.0 && shipmentWeight <= 10)
            {
                double naKM = distance * 0.05;
                double expressCena = 0.05 * 0.4;
                double nadcenka = expressCena * shipmentWeight;
                nadcenka *= distance;
                price = naKM + nadcenka;
            }
            else if (shipmentWeight >= 11 && shipmentWeight <= 40)
            {
                double naKM = distance * 0.10;
                double expressCena = 0.10 * 0.05;
                double nadcenka = expressCena * shipmentWeight;
                nadcenka *= distance;
                price = naKM + nadcenka;
            }
            else if (shipmentWeight >= 41 && shipmentWeight <= 90)
            {
                double naKM = distance * 0.15;
                double expressCena = 0.15 * 0.02;
                double nadcenka = expressCena * shipmentWeight;
                nadcenka *= distance;
                price = naKM + nadcenka;
            }
            else if (shipmentWeight >= 91 && shipmentWeight <= 150)
            {
                double naKM = distance * 0.20;
                double expressCena = 0.20 * 0.01;
                double nadcenka = expressCena * shipmentWeight;
                nadcenka *= distance;
                price = naKM + nadcenka;
            }
        }

        Console.WriteLine($"The delivery of your shipment with weight of {shipmentWeight:F3} kg. would cost {price:F2} lv.");
    }
}

