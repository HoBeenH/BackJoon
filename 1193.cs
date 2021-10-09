using System;

namespace BackJoon
{
    class BackJoon1193
    {
        static void Quest()
        {
            int findZigZag = int.Parse(Console.ReadLine());
            int map = 1;
            if (findZigZag == 1)
            {
                Console.Write("1/1");
            }
            else
            {
                for (int i = 2; ; i++)
                {
                    if (map < findZigZag && findZigZag <= map + i)
                    {
                        int temp = findZigZag - map;
                        if (i % 2 == 0)
                        {
                            Console.Write($"{temp}/{i - temp + 1}");
                            return;
                        }
                        else if (i % 2 == 1)
                        {
                            Console.Write($"{i - temp + 1}/{temp}");
                            return;
                        }
                    }
                    map += i;
                }
            }
        }
    }
}