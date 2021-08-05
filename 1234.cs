using System;
class BackJoon1234
{
    static void Quest()
    {
        int[] music = new int[8];
        for (int i = 1; i < music.Length + 1; i++)
        {
            music[i - 1] = i;
        }
        string[] input = Console.ReadLine().Split(" ");
        int[] count = new int[3];
        for (int i = 0; i < input.Length; i++)
        {
            if (music[i] == int.Parse(input[i]))
            {
                count[0] += 1;
            }
            else if (music[input.Length - 1 - i] == int.Parse(input[i]))
            {
                count[1] += 1;
            }
            else
            {
                break;
            }
        }
        if (count[0] == 8)
        {
            Console.Write("ascending");
        }
        else if (count[1] == 8)
        {
            Console.Write("descending");
        }
        else
        {
            Console.Write("mixed");
        }
    }
}