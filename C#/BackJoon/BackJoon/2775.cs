using System;
using System.Text;
class BackJoon2775
{
    static void Quest()
    {
        StringBuilder result = new StringBuilder();
        int testCase = int.Parse(Console.ReadLine());
        int[,] apt = new int[15, 15];
        for (int i = 0; i < 15; i++)
        {
            apt[i, 0] = 1;
            apt[0, i] = i + 1;
        }
        for (int i = 1; i < 15; i++)
        {
            for (int j = 1; j < 14; j++)
            {
                apt[i, j] = apt[i, j - 1] + apt[i - 1, j];
            }
        }
        for (int i = 0; i < testCase; i++)
        {
            int floor = int.Parse(Console.ReadLine());
            int room = int.Parse(Console.ReadLine());
            result.Append($"{apt[floor, room - 1]}\n");
        }
        Console.WriteLine(result);
    }
}
