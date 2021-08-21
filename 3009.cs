using System;
class BackJoon3009
{
    static void Quest()
    {
        int[] vectorX = new int[3];
        int[] vectorY = new int[3];
        string[] temp = new string[2];
        for (int i = 0; i < 3; i++)
        {
            temp = Console.ReadLine().Split(" ");
            vectorX[i] = int.Parse(temp[0]);
            vectorY[i] = int.Parse(temp[1]);
        }
        int resultX;
        int resultY;

        if (vectorX[0] != vectorX[1])
        {
            if (vectorX[1] != vectorX[2])
            {
                resultX = vectorX[1];
            }
            else
            {
                resultX = vectorX[0];
            }
        }
        else
        {
            resultX = vectorX[2];
        }
        if (vectorY[0] != vectorY[1])
        {
            if (vectorY[1] != vectorY[2])
            {
                resultY = vectorY[1];
            }
            else
            {
                resultY = vectorY[0];
            }
        }
        else
        {
            resultY = vectorY[2];
        }
        Console.Write($"{resultX} {resultY}");
    }
}