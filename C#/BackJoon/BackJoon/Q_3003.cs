using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackJoon
{
    internal class Q_3003
    {
        public enum EType
        {
            None,
            
            King,
            Queen,
            Rook,
            Bishop,
            Knight,
            Pawn,
            
            Max
        }

        public static void EntryPoint(string[] args)
        {
            Dictionary<EType, int> _dicMaxCnt_ByType = new Dictionary<EType, int>
            {
                {EType.King, 1},
                {EType.Queen, 1},
                {EType.Rook, 2},
                {EType.Bishop, 2},
                {EType.Knight, 2},
                {EType.Pawn, 8},
            };
            
            int[] _input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var _sb = new StringBuilder();
            
            for (var i = EType.None + 1; i < EType.Max; i++)
            {
                var _curMaxCnt = _dicMaxCnt_ByType[i];
                _sb.Append($"{_curMaxCnt - _input[(int) i - 1]}");
                if (i != EType.Max - 1)
                {
                    _sb.Append(" ");
                }
            }
            
            Console.Write(_sb.ToString());
        }
    }
}