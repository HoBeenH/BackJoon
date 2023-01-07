using System;
using System.Text;

namespace ConsoleApp1
{
    static class BackJoon11729
    {
        private static int allCount = 0;

        private static void Quest(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var result = new StringBuilder();
            Hanoi(count, 1, 2, 3);
            Console.WriteLine(allCount);
            Console.Write(result);

            void Hanoi(int temp, int from, int middle, int point)
            {
                if (temp == 0)
                {
                    return;
                }

                Hanoi(temp - 1, from, point, middle);
                result.Append($"{from} {point}\n");
                Hanoi(temp - 1, middle, from, point);
                allCount += 1;
            }
        }
    }
}