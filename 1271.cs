using System;
using System.Numerics;

namespace BackJoon
{
    class BackJoon1271
    {
        static void Quest()
        {
            string[] input = Console.ReadLine().Split(" ");
            BigInteger[] money = new BigInteger[input.Length];

            Console.Write($"{BigInteger.Parse(input[0]) / BigInteger.Parse(input[1])}\n{BigInteger.Parse(input[0]) % BigInteger.Parse(input[1])}");
        }
    }
}
