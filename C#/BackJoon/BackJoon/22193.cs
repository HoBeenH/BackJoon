using System;
using System.Numerics;

namespace BackJoon
{
    class BackJoon22193
    {
        static void Quest()
        {
            string[] input = Console.ReadLine().Split(" ");
            BigInteger first = BigInteger.Parse(Console.ReadLine());
            BigInteger second = BigInteger.Parse(Console.ReadLine());
            Console.Write($"{first * second}");
        }
    }
}