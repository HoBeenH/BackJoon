using System;
using System.Text;

class BackJoon11022
{
    static void Quest()
    {
        int max = int.Parse(Console.ReadLine());
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < max; i++)
        {
            string[] temp = Console.ReadLine().Split(" ");
            int num = int.Parse(temp[0]) + int.Parse(temp[1]);
            result.Append($"Case #{i + 1}: {temp[0]} + {temp[1]} = {num}\n");
        }
        Console.WriteLine(result.ToString());
    }
}