using System;
using System.Linq;
using System.Text;

namespace BackJoon
{
    public class BackJoon5086
    {
        private static void Quest()
        {
            var results = new StringBuilder();
            const string FACTOR = "factor";
            const string MULTIPLE = "multiple";
            const string NEITHER = "neither";
            while (true)
            {
                var nums = Console.ReadLine()?.Split().Select(int.Parse).ToArray();
                var first = nums?[0];
                var second = nums?[1];
                if (first == 0 && second == 0)
                {
                    Console.Write(results);
                    return;
                }

                if (second % first == 0)
                {
                    results.Append($"{FACTOR}\n");
                }
                else if (first % second == 0)
                {
                    results.Append($"{MULTIPLE}\n");
                }
                else
                {
                    results.Append($"{NEITHER}\n");
                }
            }
        }
    }
}