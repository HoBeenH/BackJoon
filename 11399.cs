using System;
class BackJoon11399
{
    static void Quest()
    {
        int count = int.Parse(Console.ReadLine());
        string[] temp = Console.ReadLine().Split(" ");
        int[] index = new int[count];
        for (int i = 0; i < index.Length; i++)
        {
            index[i] = int.Parse(temp[i]);
        }
        for (int i = index.Length - 1; i >= 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                if (index[j] > index[j + 1])
                {
                    int num = index[j];
                    index[j] = index[j + 1];
                    index[j + 1] = num;
                }
            }
        }
        //3 1 4 3 2
        int result = 0;
        for (int i = 1; i <= index.Length; i++)
        {
            for (int j = 0; j < i; j++)
            {
                result += index[j];
            }
        }
        Console.Write(result);
    }
}