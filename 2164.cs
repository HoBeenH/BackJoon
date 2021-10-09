using System;
using System.Collections.Generic;

namespace BackJoon
{
    class BackJoon2164
    {
        static void Quest()
        {
            int num = int.Parse(Console.ReadLine());
            Queue<int> cards = new Queue<int>();
            for (int i = 1; i < num + 1; i++)
            {
                cards.Enqueue(i);
            }
            while (cards.Count != 1)
            {
                cards.Dequeue();
                int temp = cards.Dequeue();
                cards.Enqueue(temp);
            }
            Console.WriteLine(cards.Peek());
        }
    }
}