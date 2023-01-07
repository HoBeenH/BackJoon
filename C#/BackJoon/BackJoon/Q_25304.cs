using System;
using System.Linq;

namespace BackJoon
{
    public class Q_25304
    {
        public static void EntryPoint(string[] args)
        {
            var _maxPrice = long.Parse(Console.ReadLine());
            var _totalCnt = int.Parse(Console.ReadLine());
            long _checkPrice = 0;

            for (var i = 0; i < _totalCnt; i++)
            {
                var _purchases = Console.ReadLine().Split().Select(int.Parse).ToArray();

                _checkPrice += _purchases[0] * _purchases[1];
            }

            Console.WriteLine(_checkPrice == _maxPrice ? "Yes" : "No");
        }
    }
}