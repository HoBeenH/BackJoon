using System;
using System.Linq;

namespace BackJoon15649
{
    internal class BJ
    {
        public static void Main(string[] args)
        {
            var _i = int.Parse(Console.ReadLine());
            var _num = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var _min = _num.Min();
            var _max = _num.Max();
            Console.Write(_min * _max);
        }
    }
}