using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BackJoon
{
    internal class Q_14425
    {
        public static void EntryPoint(string[] args)
        {
            using (var _sr = new StreamReader(Console.OpenStandardInput()))
            {
                var _cntAndLen = _sr.ReadLine().Split().Select(int.Parse).ToArray();
                var _set = new HashSet<string>();

                var _hasCnt = _cntAndLen[0];
                var _findCnt = _cntAndLen[1];
                
                for (var i = 0; i < _hasCnt; i++)
                    _set.Add(_sr.ReadLine());

                var _result = 0;
                for (var i = 0; i < _findCnt; i++)
                {
                    if (_set.Contains(_sr.ReadLine()))
                        _result++;
                }
                
                Console.WriteLine(_result.ToString());
            }
        }
    }
}