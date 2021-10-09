using System;

namespace BackJoon
{
    class BackJoon2869
    {
        static void Quest()
        {
            string[] input = Console.ReadLine().Split(" ");
            long up = long.Parse(input[0]);
            long down = long.Parse(input[1]);
            long max = long.Parse(input[2]);

            Console.Write((max - down - 1) / (up - down) + 1);
        }
    }
}
