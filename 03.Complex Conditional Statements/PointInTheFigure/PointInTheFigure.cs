using System;

class PointInTheFigure
{
    public static void Main()
    {
        double h = double.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        // upper rect
        double UpperLeftAngleX = h;
        double UpperRightAngleX = h * 2;
        double UpperLeftAngleY = h;
        double UpperRightAngleY = h * 4;
        // bottom rect
        double BottomLeftAngleX = 0;
        double BottomRightAngleX = h * 3;
        double BottomLeftAngleY = 0;
        double BottomRightAngleY = h;

        double UpperRect; // -1 - outside  ; 0- border ; 1- inside
        double BottomRect;
        bool commonWall = x < h || x > h * 2;

        if ((x >= BottomLeftAngleX && x <= BottomRightAngleX) &&
            (y >= BottomLeftAngleY && y <= BottomRightAngleY))
        {
            if ((x == BottomLeftAngleX || x == BottomRightAngleX) ||
                (y == BottomLeftAngleY || y == BottomRightAngleY && commonWall))
            {
                BottomRect = 0;
            }
            else
            {
                BottomRect = 1;
            }

        }
        else
        {
            BottomRect = -1;
        }


        if ((x >= UpperLeftAngleX && x <= UpperRightAngleX) &&
           (y >= UpperLeftAngleY && y <= UpperRightAngleY))
        {
            if ((x == UpperLeftAngleX || x == UpperRightAngleX) ||
                (y == UpperRightAngleY || y == UpperLeftAngleY && commonWall))
            {
                UpperRect = 0;
            }
            else
            {
                UpperRect = 1;
            }

        }
        else
        {
            UpperRect = -1;
        }


        if (UpperRect == -1 && BottomRect == -1)
        {
            Console.WriteLine("Outside");
        }
        else if (UpperRect == 0 || UpperRect == 0)
        {
            Console.WriteLine("Border");
        }
        else
        {
            Console.WriteLine("Inside");
        }
    }
}
