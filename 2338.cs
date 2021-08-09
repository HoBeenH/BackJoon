using System;
using System.Numerics;
class BackJoon2338
{
    static void Quest()
    {
        BigInteger first = BigInteger.Parse(Console.ReadLine());
        BigInteger second = BigInteger.Parse(Console.ReadLine());
        Console.Write($"{first + second}\n{first - second}\n{first * second}");
    }
}