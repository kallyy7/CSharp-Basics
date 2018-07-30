using System;

class LeftAndRightSum
{
    public static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());
        int rightSum = 0;
        int leftSum = 0;

        for (int i = 0; i < inputNumber; i++)
        {
            int currentLeftSum = int.Parse(Console.ReadLine());
            leftSum += currentLeftSum;
        }

        for (int i = 0; i < inputNumber; i++)
        {
            int currentRightSum = int.Parse(Console.ReadLine());
            rightSum += currentRightSum;
        }

        if (leftSum == rightSum)
        {
            Console.WriteLine("Yes, sum = " + leftSum);
        }
        else
        {
            Console.WriteLine("No, diff = " + Math.Abs(leftSum - rightSum));
        }
    }
}
