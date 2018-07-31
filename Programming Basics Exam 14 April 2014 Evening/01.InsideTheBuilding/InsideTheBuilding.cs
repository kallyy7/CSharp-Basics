using System;

public class InsideTheBuilding
{
    public static void Main()
    {
        int h = int.Parse(Console.ReadLine());

        string insideOrOutside = null;

        for (int i = 1; i <= 5; i++)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int botRectStartX = 0;
            int botRectEndX = 3 * h;

            int botRectStartY = 0;
            int botRectEndY = h;

            int topRectStartX = h;
            int topRectEndX = 2 * h;

            int topRectStartY = h;
            int topRectEndY = 4 * h;
            int isInBottomRectangle;
            int isInTopRectangle;


            if ((x >= botRectStartX && x <= botRectEndX) && (y >= botRectStartY && y <= botRectEndY))
            {
                isInBottomRectangle = 1;
            }
            else
            {
                isInBottomRectangle = 0;
            }
            if ((x >= topRectStartX && x <= topRectEndX) && (y >= topRectStartY && y <= topRectEndY))
            {
                isInTopRectangle = 1;
            }
            else
            {
                isInTopRectangle = 0;
            }
            if (isInBottomRectangle == 0 && isInTopRectangle == 0)
            {
                insideOrOutside += "outside\n";

            }
            else
            {
                insideOrOutside += "inside\n";
            }
        }

        Console.WriteLine(insideOrOutside);
    }
}