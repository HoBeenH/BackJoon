using System;

namespace BackJoon
{
    internal class Q_2566
    {
        public struct Vector
        {
            public int x;
            public int y;
            public int num;
            
            public override string ToString() => $"{num.ToString()}\n{y.ToString()} {x.ToString()}";
        }
        public static void EntryPoint(string[] args)
        {
            var _vec = new Vector
            {
                x = 1,
                y = 1,
                num = 0
            };
            for (int i = 1; i <= 9; i++)
            {
                var _input = Console.ReadLine();
                if (string.IsNullOrEmpty(_input))
                    break;

                var _split = _input.Split();
                var _len = _split.Length;
                for (var j = 0; j < _len; j++)
                {
                    var _toI32 = int.Parse(_split[j]);

                    if (_vec.num < _toI32)
                    {
                        _vec.num = _toI32;
                        _vec.x = j + 1;
                        _vec.y = i;
                    }
                }
            }

            Console.WriteLine(_vec.ToString());
        }
    }
}