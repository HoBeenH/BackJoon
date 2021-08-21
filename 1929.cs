using System;
using System.Text;
class BackJoon1929
{
    static void Quese()
    {
        StringBuilder result = new StringBuilder();
        string[] temp = Console.ReadLine().Split(" ");
        int min = int.Parse(temp[0]);
        if (min == 1)
        {
            min += 1;
        }
        int max = int.Parse(temp[1]);
        bool check;
        for (int i = min; i <= max; i++)
        {
            check = true;
            for (int j = 2; j <= MathF.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    check = false;
                    break;
                }
            }
            if (check)
            {
                result.Append($"{i}\n");
            }
        }
        Console.Write(result);
    }
}