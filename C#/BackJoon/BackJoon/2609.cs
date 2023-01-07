using System;
using System.Linq;

namespace BackJoon15649
{
    internal class BJ
    {
        public static void Main(string[] args)
        {
            var _i = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var _max = GCD(_i[0], _i[1]);
            var _min = LCM(_i[0] , _i[1]);
            Console.Write($"{_max}\n{_min}");
        }

        private static int GCD(int x, int y)
        {
            while (y != 0)
            {
                var _r = x % y;
                x = y;
                y = _r;
            }

            return x;
        }

        private static int LCM(int x, int y) => x * y / GCD(x, y);
    }
}