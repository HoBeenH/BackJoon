using System;
using System.Linq;
using System.Text;

namespace BackJoon15649
{
    internal class BJ
    {
        public static void Main(string[] args)
        {
            var _l = int.Parse(Console.ReadLine());
            var _results = new StringBuilder();
            for (var i = 0; i < _l; i++)
            {
                var _i = Console.ReadLine().Split().Select(int.Parse).ToArray();
                var _g = LCM(_i[0], _i[1]);
                _results.Append($"{_g}\n");
            }
            Console.Write(_results);
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