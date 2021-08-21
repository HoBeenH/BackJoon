using System;
using System.Numerics;
class BackJoon10757
{
    static void Quest()
    {
        string[] input = Console.ReadLine().Split(" ");
        BigInteger num1 = BigInteger.Parse(input[0]);
        BigInteger num2 = BigInteger.Parse(input[1]);
        Console.Write(num1 + num2);
    }
}