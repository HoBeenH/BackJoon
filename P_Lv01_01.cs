using System;
using System.Linq;

namespace Programmers
{
    public class Test
    {
        public static void Main(string[] args)
        {
            var _lotto = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var _winNums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var _result = solution(_lotto, _winNums);
            foreach (var VARIABLE in _result)
            {
                Console.Write(VARIABLE);
            }
        }

        public static int[] solution(int[] lotto, int[] win_nums)
        {
            int _zeroCnt = 0, _resultCnt = 0;
            foreach (var t in lotto)
            {
                if (t == 0)
                {
                    _zeroCnt += 1;
                    continue;
                }

                if (win_nums.Any(t1 => t == t1))
                {
                    _resultCnt += 1;
                }
            }

            return new int[] {FindWinner(_resultCnt + _zeroCnt), FindWinner(_resultCnt)};
        }

        private static int FindWinner(int num)
        {
            var _return = 0;
            switch (num)
            {
                case 0:
                    _return = 6;
                    break;
                case 1:
                    _return = 6;
                    break;
                case 2:
                    _return = 5;
                    break;
                case 3:
                    _return = 4;
                    break;
                case 4:
                    _return = 3;
                    break;
                case 5:
                    _return = 2;
                    break;
                case 6:
                    _return = 1;
                    break;
            }

            return _return;
        }
        //1 = 1등
        //2 = 5개
        //3 = 4
        //4 = 3
        //5 = 2
        //6 = 탈락
    }
}