using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackJoon1966
{
    public class BJ
    {
        public static void Main(string[] args)
        {
            var _testCase = int.Parse(Console.ReadLine());
            var _queue = new Queue<int>();
            var _result = new StringBuilder();
            for (var i = 0; i < _testCase; i++)
            {
                var _num = Console.ReadLine().Split().Select(int.Parse).ToArray();
                var _length = _num[0];
                var _find = _num[1];
                var _list = Console.ReadLine().Split().Select(int.Parse).ToArray();
                var _findNum = _list[_find];
                _list[_find] = 0;

                for (var j = 0; j < _length; j++)
                    _queue.Enqueue(_list[j]);

                var _count = 0;
                while (true)
                {
                    if (_queue.Count == 0)
                        break;

                    var _max = _queue.Max();
                    var _current = _queue.Peek();
                    if (_max <= _findNum)
                    {
                        if (_current == _findNum)
                        {
                            _queue.Dequeue();
                            _count++;
                        }
                        else if (_current == 0)
                        {
                            _count++;
                            break;
                        }
                        else
                        {
                            var _tmp = _queue.Dequeue();
                            _queue.Enqueue(_tmp);
                        }
                    }
                    else
                    {
                        if (_current == _max)
                        {
                            _queue.Dequeue();
                            _count++;
                        }
                        else
                        {
                            var _tmp = _queue.Dequeue();
                            _queue.Enqueue(_tmp);
                        }
                    }
                }

                _result.Append($"{_count}\n");
                _queue.Clear();
            }

            Console.Write(_result);
        }
    }
}