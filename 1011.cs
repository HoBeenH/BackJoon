using System;
using System.Text;
class BackJoon1011
{
    static void Quest()
    {
        StringBuilder resultBuilder = new StringBuilder();
        int testCase = int.Parse(Console.ReadLine());
        for (int i = 0; i < testCase; i++)
        {
            string[] temp = Console.ReadLine().Split(" ");
            long first = long.Parse(temp[0]);
            long max = long.Parse(temp[1]);
            long point = max - first;

            long sqrt = (long)MathF.Sqrt(point);
            if (sqrt == MathF.Sqrt(point))
            {
                resultBuilder.Append($"{2 * sqrt - 1}\n");
            }
            else if (sqrt * sqrt + sqrt >= point)
            {
                resultBuilder.Append($"{sqrt * 2}\n");
            }
            else
            {
                resultBuilder.Append($"{sqrt * 2 + 1}\n");
            }
        }
        Console.Write(resultBuilder);
    }
}