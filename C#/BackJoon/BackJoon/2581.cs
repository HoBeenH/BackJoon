using System;

namespace BackJoon
{
    class BackJoon2581
    {
        static void Quest()
        {
            int firstNum = int.Parse(Console.ReadLine());
            if (firstNum == 1)
            {
                firstNum += 1;
            }
            int secondNum = int.Parse(Console.ReadLine());
            int sum = 0;
            int min = 0;
            bool check = false;

            for (int i = firstNum; i <= secondNum; i++)
            {
                for (int j = 2; j <= MathF.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        goto EXIT;
                    }
                }
                sum += i;
                if (!check)
                {
                    check = true;
                    min = i;
                    continue;
                }
            EXIT:;
            }
            if (!check)
            {
                Console.Write(-1);
                return;
            }
            Console.Write($"{sum}\n{min}");
        }
    }
}