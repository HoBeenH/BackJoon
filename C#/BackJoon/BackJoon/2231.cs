using System;

class BackJoon2231
{
    static void Quest()
    {
        string input = Console.ReadLine();
        int maxInt = int.Parse(input);
        if (maxInt < 10)
        {
            if (maxInt % 2 == 0)
            {
                Console.Write(maxInt / 2);
                return;
            }
            else
            {
                Console.Write(0);
                return;
            }
        }

        int result = maxInt - (input.Length) * 9;
        if (result < 0)
        {
            result = maxInt - (input.Length - 1) * 9;
        }
        for (int i = result; i < maxInt; i++)
        {
            int temp1 = i;
            string[] temp = new string[i.ToString().Length];
            for (int j = 0; j < temp.Length; j++)
            {
                temp[j] = i.ToString().Substring(j, 1);
            }
            for (int j = 0; j < temp.Length; j++)
            {
                temp1 += int.Parse(temp[j]);
            }
            if (temp1 == maxInt)
            {
                Console.Write(i);
                return;
            }
        }
        Console.Write(0);
    }
}