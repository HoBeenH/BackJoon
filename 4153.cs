using System;
using System.Text;
class BackJoon4153
{
    static void Quest()
    {
        StringBuilder result = new StringBuilder();
        while (true)
        {
            string[] input = Console.ReadLine().Split(" ");
            long[] num = new long[input.Length];

            if (int.Parse(input[0]) + int.Parse(input[1]) + int.Parse(input[2]) == 0)
            {
                break;
            }
            if (int.Parse(input[0]) == 0 || int.Parse(input[1]) == 0 || int.Parse(input[2]) == 0)
            {
                result.Append("wrong\n");
                continue;
            }


            for (int i = 0; i < input.Length; i++)
            {
                num[i] = long.Parse(input[i]);
            }
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i; j < input.Length; j++)
                {
                    if (num[i] > num[j])
                    {
                        long temp = num[i];
                        num[i] = num[j];
                        num[j] = temp;
                    }
                }
            }
            if (MathF.Pow(num[2], 2) == (MathF.Pow(num[0], 2) + MathF.Pow(num[1], 2)))
            {
                result.Append("right\n");
            }
            else
            {
                result.Append("wrong\n");
            }
        }
        Console.Write(result);
    }
}