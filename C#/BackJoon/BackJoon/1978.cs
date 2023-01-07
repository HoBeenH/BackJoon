using System;
class BackJoon1978
{
    static void Quest()
    {
        int num = int.Parse(Console.ReadLine());
        int count = 0;
        string[] inputNum = Console.ReadLine().Split();
        for (int k = 0; k < num; k++)
        {
            int input = int.Parse(inputNum[k]);
            if (input == 1)
            {
                continue;
            }
            bool temp = true;
            for (int j = 2; j <= MathF.Sqrt(input); j++)
            {
                if (input % j == 0)
                {
                    temp = false;
                    break;
                }
            }
            if (temp)
            {
                count += 1;
            }
        }
        Console.Write(count);
    }
}