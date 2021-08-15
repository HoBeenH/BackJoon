using System;
using System.Text;
class BackJoon11653
{
    static void Quest()
    {
        StringBuilder result = new StringBuilder();
        float inputNum = float.Parse(Console.ReadLine());
        int num = 2;
        if (inputNum == 1)
        {
            return;
        }
        bool prime = true;
        for (int i = 2; i <= (int)MathF.Sqrt(inputNum); i++)
        {
            if (inputNum % i == 0)
            {
                prime = false;
                break;
            }
        }
        if (prime)
        {
            Console.Write(inputNum);
            return;
        }
        else
        {
            while (inputNum != 1)
            {
                while (inputNum % num == 0)
                {
                    inputNum /= num;
                    result.Append($"{num}\n");
                }
                num++;
            }
        }
        Console.Write(result);
    }
}