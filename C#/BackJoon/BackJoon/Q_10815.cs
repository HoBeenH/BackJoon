using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackJoon
{
    public class Q_10815
    {
        public static void EntryPoint(string[] args)
        {
            var _hasCnt = int.Parse(Console.ReadLine());
            var _hasItems = Console.ReadLine().Split().Select(int.Parse);
            var _set = new HashSet<int>(_hasItems);

            var _findCnt = int.Parse(Console.ReadLine());
            var _findItems = Console.ReadLine().Split().Select(int.Parse);

            var _sb = new StringBuilder();
            const string Has = "1 ";
            const string NotHas = "0 ";
            
            foreach (var i in _findItems)
            {
                _sb.Append(_set.Add(i) ? NotHas : Has);
            }
            
            Console.WriteLine(_sb.ToString());

        }
    }
}