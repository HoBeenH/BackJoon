using System;
using System.Text;
using System.Collections.Generic;
class BackJoon9012
{
    static void Main()
    {
        int testCase = int.Parse(Console.ReadLine());
        Stack<char> result = new Stack<char>();
        StringBuilder write = new StringBuilder();
        int q = 0;
        while (q < testCase)
        {
            write.Clear();
            result.Clear();
            char[] temp = Console.ReadLine().ToCharArray();
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] == '(')
                {
                    result.Push(temp[i]);
                    continue;
                }
                else
                {
                    if (result.Count != 0 && result.Peek() == '(')
                    {
                        result.Pop();
                        continue;
                    }
                    else
                    {
                        result.Push(temp[i]);
                        break;
                    }
                }
            }
            if (result.Count == 0)
            {
                write.Append("YES");
                Console.WriteLine(write);
            }
            else
            {
                write.Append("NO");
                Console.WriteLine(write);
            }
            q++;
        }
    }
}