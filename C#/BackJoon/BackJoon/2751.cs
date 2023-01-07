using System;
using System.Text;

namespace ConsoleApplication1
{
    internal class BackJoon2751
    {
        public static void Main(string[] args)
        {
            var _index = int.Parse(Console.ReadLine());
            var _arr = new int[_index];
            for (var i = 0; i < _index; i++)
            {
                _arr[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(_arr);
            var _result = new StringBuilder();
            for (var i = 0; i < _arr.Length; i++)
            {
                _result.Append($"{_arr[i]}\n");
            }
            Console.Write(_result);
        }
    }
}