using System;

class BackJoon10039
{

    static void Quest()
    {
        int score = 0;
        for (int i = 0; i < 5; i++)
        {
            int temp = int.Parse(Console.ReadLine());
            if (temp < 40)
            {
                score += 40;
            }
            else
            {
                score += temp;
            }
        }

        Console.Write(score / 5);
    }
}