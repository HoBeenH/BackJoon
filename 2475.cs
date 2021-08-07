using System;
class BackJoon2475
{
    static void Quest()
    {
        string[] input = Console.ReadLine().Split(" ");
        int[] point = new int[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            point[i] = (int)MathF.Pow((int.Parse(input[i])), 2);
        }
        int result = 0;
        foreach (var item in point)
        {
            result += item;
        }
        Console.Write(result % 10);
    }
}