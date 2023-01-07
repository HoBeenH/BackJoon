using System;
using System.Text;

namespace BackJoon
{
    class BackJoon11047
    {
        static void Quest()
        {
            string[] countAndMax = Console.ReadLine().Split(" ");
            int[] money = new int[int.Parse(countAndMax[0])];
            int max = int.Parse(countAndMax[1]);
            for (int i = 0; i < money.Length; i++)
            {
                money[i] = int.Parse(Console.ReadLine());
            }
            int count = 0;
            for (int i = money.Length - 1; i >= 0; i--)
            {
                if (max >= money[i])
                {
                    while (max >= money[i])
                    {
                        max -= money[i];
                        count++;
                    }
                }
            }
            Console.Write(count);
        }
    }
}