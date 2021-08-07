using System;
class BackJoon1065
{
    static void Quest()
    {
        string inputNum = Console.ReadLine();
        char[] input = inputNum.ToCharArray();
        string[] temp = new string[input.Length];
        int[] inputToInt = new int[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            temp[i] = input[i].ToString();
            inputToInt[i] = int.Parse(temp[i]);
        }
        int count = 0;
        if (int.Parse(inputNum) < 100)
        {
            count = int.Parse(inputNum);
            Console.Write(count);
        }
        else if (int.Parse(inputNum) < 1000)
        {
            for (int i = 100; i <= int.Parse(inputNum); i++)
            {
                string num = i.ToString();
                int[] temp2 = new int[3];
                for (int j = 0; j < 3; j++)
                {
                    temp2[j] = int.Parse(num.Substring(j, 1));
                }
                if (temp2[0] - temp2[1] == temp2[1] - temp2[2])
                {
                    count += 1;
                }
            }
            count += 99;
            Console.Write(count);
        }
        else
        {
            for (int i = 100; i <= int.Parse(inputNum); i++)
            {
                string num = i.ToString();
                if (int.Parse(num) < 1000)
                {
                    int[] temp2 = new int[3];
                    for (int j = 0; j < 3; j++)
                    {
                        temp2[j] = int.Parse(num.Substring(j, 1));
                    }
                    if (temp2[0] - temp2[1] == temp2[1] - temp2[2])
                    {
                        count += 1;
                    }
                }
                else
                {
                    break;
                }
            }
            count += 99;
            Console.Write(count);
        }
    }
}
