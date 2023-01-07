using System;

namespace BackJoon
{
    class BackJoon1712
    {
        static void Quest()
        {
            string[] input = Console.ReadLine().Split(" ");
            int tax = int.Parse(input[0]);
            int pay = int.Parse(input[1]);
            int cell = int.Parse(input[2]);
            if (pay >= cell)
            {
                Console.Write("-1");
                return;
            }
            else if (tax == 0 && pay < cell)
            {
                Console.Write("1");
                return;
            }

            int result = tax / (cell - pay);
            Console.Write(result + 1);
        }
    }
}