using System;
using System.Collections.Generic;

class BackJoon11720
{
    static void Quest()
    {
        int max = int.Parse(Console.ReadLine());
        string temp = Console.ReadLine();
        int result = 0;
        int[] num = new int[max];

        for (int i = 0; i < max; i++)
        {
            num[i] = int.Parse(temp.Substring(i, 1));
            result += num[i];
        }
        Console.Write(result);
    }
}