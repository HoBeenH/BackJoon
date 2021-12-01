using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackJoon15649
{
    public class BJ
    {
        public static void Main(string[] args)
        {
            var _input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var _queue = new RotQueue(_input[0]);
            var _getNums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (var i = 0; i < _input[1]; i++)
            {
                _queue.NumCount(_getNums[i]);
            }
            Console.Write(_queue.Result());
        }

        private class RotQueue
        {
            private readonly List<int> nums = new List<int>();
            private int length;
            private static int count = 0;

            public RotQueue(int length)
            {
                this.length = length;
                for (var i = 1; i <= length; i++)
                {
                    nums.Add(i);
                }
            }

            public void NumCount(int pivot)
            {
                int _l = 0, _r = 0;
                _r += nums.TakeWhile(t => t != pivot).Count();
                for (var i = length - 1; i >= 0; i--)
                {
                    if (nums[i] == pivot)
                        break;
                    _l += 1;
                }

                if (_l >= _r)
                {
                    while (Peek() != pivot)
                        MoveL();
                }
                else
                {
                    while (Peek() != pivot)
                        MoveR();
                }
                DeQueue();
            }

            public int Result() => count;

            private void DeQueue()
            {
                nums.RemoveAt(0);
                length = nums.Count;
            }

            private int Peek() => nums[0];

            private void MoveL()
            {
                var _value = nums[0];
                nums.Add(_value);
                nums.RemoveAt(0);
                count += 1;
            }

            private void MoveR()
            {
                var _value = nums[nums.Count - 1];
                nums.RemoveAt(nums.Count - 1);
                nums.Insert(0, _value);
                count += 1;
            }
        }
    }
}