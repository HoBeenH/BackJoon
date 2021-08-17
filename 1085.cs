using System;
class BackJoon1085
{
    static void Quest()
    {
        string[] temp = Console.ReadLine().Split(" ");
        int nowX = int.Parse(temp[0]);
        int nowY = int.Parse(temp[1]);
        int maxX = int.Parse(temp[2]);
        int maxY = int.Parse(temp[3]);

        int disX = maxX - nowX > nowX ? nowX : maxX - nowX;
        int disY = maxY - nowY > nowY ? nowY : maxY - nowY;
        int resutl = disX > disY ? disY : disX;
        Console.Write(resutl);
    }
}