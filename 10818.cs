using System;

namespace BackJoon
{
    class BackJoon10818
    {
        static void Quest(string[] args)
        {
            int numCount = int.Parse(Console.ReadLine());
            string[] temp = Console.ReadLine().Split(" ");
            int[] num = new int[temp.Length];
            for (int i = 0; i < numCount; i++)
            {
                num[i] = int.Parse(temp[i]);
            }
            int min = num[0];
            int max = num[0];
            for (int i = 0; i < num.Length; i++)
            {
                if (min > num[i])
                {
                    min = num[i];
                }
                if (max < num[i])
                {
                    max = num[i];
                }
            }
            Console.Write($"{min} {max}");
        }

    }
}
