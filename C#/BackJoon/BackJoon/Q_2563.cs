using System;
using System.IO;
using System.Linq;

namespace BackJoon
{
    public class Q_2563
    {
        public static void EntryPoint(string[] args)
        {
            var _canvas = new int[100, 100];
            using (var _reader = new StreamReader(Console.OpenStandardInput()))
            {
                var _cnt = int.Parse(_reader.ReadLine());
                var _result = 0;
                for (var i = 0; i < _cnt; i++)
                {
                    var _xy = _reader.ReadLine().Split().Select(int.Parse).ToArray();

                    for (int x = _xy[0]; x < _xy[0] + 10; x++)
                    {
                        for (int y = _xy[1]; y < _xy[1] + 10; y++)
                        {
                            if (_canvas[x,y] == 1)
                                continue;

                            _canvas[x, y] = 1;
                            _result++;
                        }
                    }
                }

                Console.WriteLine(_result.ToString());
            }
        }
    }
}