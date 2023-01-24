using System;
using System.Linq;

namespace BackJoon
{
    internal class Q_10807
    {
        public static void EntryPoint(string[] args)
        {
            var _allNumLen = int.Parse(Console.ReadLine());
            var _allInputNum = Console.ReadLine().Split();
            var _targetNum = Console.ReadLine();

            var _cnt = _allInputNum.Where(x => x.Equals(_targetNum));
            
            Console.WriteLine(_cnt.Count().ToString());
        }
    }
}