using System;
using System.Text;
using System.Collections.Generic;

namespace BackJoon
{
    class BackJoon18258
    {
        static void Quest()
        {
            StringBuilder result = new StringBuilder();
            Queue<int> box = new Queue<int>();
            int testCase = int.Parse(Console.ReadLine());
            int a = 0;
            for (int i = 0; i < testCase; i++)
            {
                var input = Console.ReadLine().Split(" ");
                switch (input[0])
                {
                    case "pop":
                        result.Append($"{(box.Count == 0 ? -1 : box.Dequeue())}\n");
                        break;

                    case "size":
                        result.Append($"{box.Count}\n");
                        break;

                    case "empty":
                        result.Append($"{(box.Count == 0 ? 1 : 0)}\n");
                        break;

                    case "front":
                        result.Append($"{(box.Count == 0 ? -1 : box.Peek())}\n");
                        break;

                    case "back":
                        result.Append($"{(box.Count == 0 ? -1 : a)}\n");
                        break;

                    case "push":
                        a = int.Parse(input[1]);
                        box.Enqueue(a);
                        break;
                }
            }
            Console.Write(result);
        }
    }
}