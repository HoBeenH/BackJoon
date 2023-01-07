using System;
class BackJoon4948
{
    static void Quest()
    {
        while (true)
        {
            int min = int.Parse(Console.ReadLine());
            if (min == 0)
            {
                break;
            }
            int max = min * 2;
            bool check;
            int count = 0;
            for (int i = min + 1; i <= max; i++)
            {
                check = true;
                for (int j = 2; j <= MathF.Sqrt(i); j++)
                {
                    if (i % j == 0 || i == 1)
                    {
                        check = false;
                        break;
                    }
                }
                if (check)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}