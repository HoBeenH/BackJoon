using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackJoon15649
{
    internal class BJ
    {
        public static void Main(string[] args)
        {
            var _result = new StringBuilder();
            var _cnt = int.Parse(Console.ReadLine());
            var _radius = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var _first = _radius[0];
            for (var i = 1; i < _radius.Length; i++)
            {
                var _num = _radius[i];
                if (_first % _num == 0)
                {
                    _result.Append($"{_first / _num}/1\n");
                    continue;
                }
                var _tmp = LCM(_first, _num);
                _result.Append($"{_tmp / _num}/{_tmp/_first}\n");
            }
            Console.Write(_result);
        }

        private static int LCM(int x, int y)
        {
            var _tmp = x * y;
            while (y != 0)
            {
                var _r = x % y;
                x = y;
                y = _r;
            }

            return _tmp / x;
        }
    }
}