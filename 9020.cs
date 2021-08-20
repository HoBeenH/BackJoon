using System;
using System.Text;
class BackJoon9020
{
    static void Quest()
    {
        int testCase = int.Parse(Console.ReadLine());
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < testCase; i++)
        {
            int num = int.Parse(Console.ReadLine());
            for (int j = 0; j < num / 2; j++)
            {
                int min = (num / 2) - j;
                bool check = true;
                for (int k = 2; k <= MathF.Sqrt(min); k++)
                {
                    if (min % k == 0)
                    {
                        check = false;
                        break;
                    }
                }
                if (!check)
                {
                    continue;
                }
                int max = (num / 2) + j;
                for (int k = 2; k <= MathF.Sqrt(max); k++)
                {
                    if (max % k == 0)
                    {
                        check = false;
                        break;
                    }
                }
                if (check)
                {
                    result.Append($"{min} {max}\n");
                    break;
                }
            }
        }
        Console.Write(result);
    }
}