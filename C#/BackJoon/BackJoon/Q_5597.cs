using System;
using System.Collections.Generic;

namespace BackJoon
{
    internal class Q_5597
    {
        public static void EntryPoint(string[] args)
        {
            var _set = new HashSet<string>();
            const int AllStudentLen = 30;
            const int InputStudentLen = 28;
            const int Default = -1;
            
            int _a = Default;
            int _b = Default;
            
            for (var i = 0; i < InputStudentLen; i++)
            {
                _set.Add(Console.ReadLine());
            }
            
            for (var i = 1; i <= AllStudentLen; i++)
            {
                var _cur = i.ToString();
                if (_set.Add(_cur))
                {
                    if (_a == Default)
                        _a = int.Parse(_cur);
                    else
                        _b = int.Parse(_cur);
                }

                if (_a != Default && _b != Default)
                    break;
            }
            
            Console.WriteLine(_a > _b ? $"{_b.ToString()}\n{_a.ToString()}" : $"{_a.ToString()}\n{_b.ToString()}");
        }
    }
}