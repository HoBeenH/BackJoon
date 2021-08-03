using System;
using System.Text;

class BackJoon15552
{
    static void Quest()
    {
        int testCase = int.Parse(Console.ReadLine());
        StringBuilder a = new StringBuilder();
        for (int i = 0; i < testCase; i++)
        {
            string[] temp = Console.ReadLine().Split(" ");
            int result = int.Parse(temp[0]) + int.Parse(temp[1]);
            a.Append(result + "\n");
        }
        Console.WriteLine(a.ToString());
    }
}