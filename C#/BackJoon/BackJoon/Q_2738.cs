using System;
using System.Linq;
using System.Text;

namespace BackJoon
{
    internal class Q_2738
    {
        public static void EntryPoint(string[] args)
        {
            var _size = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var _n = _size[0];
            var _m = _size[1];
            var _custom = new Temp(_n * _m,_m);

            for (var i = 0; i < _n; i++)
            {
                foreach (var cur in Console.ReadLine().Split().Select(int.Parse))
                    _custom.Push(cur);
            }
            
            _custom.ResetIdx();

            for (int i = 0; i < _n; i++)
            {
                foreach (var cur in Console.ReadLine().Split().Select(int.Parse))
                    _custom.PushAdd(cur);
            }
            
            Console.WriteLine(_custom.ToString());
        }
    }

    internal class Temp
    {
        private int[] m_NumArr;
        private StringBuilder m_Sb;
        private int m_Idx = 0;
        private int m_HorizontalSize = 0;

        public Temp(int len, int horizontalSize)
        {
            m_NumArr = new int[len];
            m_Sb = new StringBuilder();
            m_HorizontalSize = horizontalSize;
        }

        public void Push(int num) => m_NumArr[m_Idx++] = num;

        public void ResetIdx() => m_Idx = 0;

        public void PushAdd(int num)
        {
            var _addNum = m_NumArr[m_Idx++] + num;
            m_Sb.Append(m_Idx % m_HorizontalSize == 0 ? $"{_addNum.ToString()}\n" : $"{_addNum.ToString()} ");
        }

        public override string ToString() => m_Sb.ToString();
    }
}