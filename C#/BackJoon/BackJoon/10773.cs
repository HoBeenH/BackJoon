using System;
using System.Collections.Generic;
class BackJoon10773
{
    static void Quest()
    {
        Stack<int> result = new Stack<int>();
        int temp = int.Parse(Console.ReadLine());
        int num;
        for (int i = 0; i < temp; i++)
        {
            num = int.Parse(Console.ReadLine());
            if (num == 0)
            {
                result.Pop();
                continue;
            }
            result.Push(num);
        }
        int end = 0;
        foreach (var item in result)
        {
            end += item;
        }
        Console.Write(end);
    }
}