using System;

class BackJoon2845
{

    static void Quest()
    {
        string[] input = Console.ReadLine().Split(" ");
        int person = int.Parse(input[0]);
        int place = int.Parse(input[1]);

        int people = person * place;
        string[] news = Console.ReadLine().Split(" ");
        int[] newPerson = new int[news.Length];
        int[] result = new int[news.Length];
        for (int i = 0; i < news.Length; i++)
        {
            newPerson[i] = int.Parse(news[i]);
            Console.Write($"{newPerson[i] - people} ");
        }

    }
}