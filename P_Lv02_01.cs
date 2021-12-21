using System;
using System.Collections.Generic;
using System.Linq;

namespace Programmers
{
    public class Test
    {
        public static void Main(string[] args)
        {
            var _progresses = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var _speeds = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var _tmp = solution(_progresses, _speeds);
            foreach (var VARIABLE in _tmp)
            {
                Console.WriteLine(VARIABLE);
            }
        }

        public static int[] solution(int[] progresses, int[] speeds)
        {
            var _result = new NewQueue(progresses, speeds);
            while (!_result.IsFinish())
            {
                _result.NextDay();
            }

            return _result.Finish();
        }

        private class NewQueue
        {
            private readonly int[] progresses;
            private readonly int[] speeds;
            private readonly List<int> _return;

            public NewQueue(int[] progresses, int[] speeds)
            {
                this.progresses = progresses;
                this.speeds = speeds;
                _return = new List<int>();
            }

            public void NextDay()
            {
                for (var i = 0; i < progresses.Length; i++)
                {
                    if (progresses[i] != -1)
                    {
                        progresses[i] += speeds[i];
                    }
                }
            }

            public bool IsFinish()
            {
                var _result = 0;
                var _finish = false;
                for (var i = 0; i < progresses.Length; i++)
                {
                    if (progresses[i] == -1)
                    {
                        continue;
                    }

                    if (progresses[i] >= 100)
                    {
                        _result += 1;
                        progresses[i] = -1;
                        _finish = true;
                    }
                    else
                    {
                        _finish = false;
                        break;
                    }
                }

                if (_result != 0)
                {
                    _return.Add(_result);
                }

                return _finish;
            }

            public int[] Finish()
            {
                return _return.ToArray();
            }
        }
    }
}