using System;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    internal class BackJoon7568
    {
        public static void Main(string[] args)
        {
            var _count = int.Parse(Console.ReadLine());
            var _x = new int[_count];
            var _y = new int[_count];
            for (var i = 0; i < _count; i++)
            {
                var _input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                _x[i] = _input[0];
                _y[i] = _input[1];
            }

            var _result = new StringBuilder();
            for (var i = 0; i < _count; i++)
            {
                var _cnt = 1;
                for (var j = 0; j < _count; j++)
                {
                    if (_x[i] < _x[j] && _y[i] < _y[j])
                    {
                        ++_cnt;
                    }
                }

                _result.Append($"{_cnt} ");
            }
            Console.Write(_result);
        }
    }
}