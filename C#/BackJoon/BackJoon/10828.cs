using System;
using System.Text;
using System.Collections.Generic;
class BackJoon10828
{
    static void Quest()
    {
        int testCase = int.Parse(Console.ReadLine());
        Stack<int> result = new Stack<int>();
        StringBuilder a = new StringBuilder();
        for (int i = 0; i < testCase; i++)
        {
            a.Clear();
            String input = Console.ReadLine();
            string[] inputToSplit = input.Split(" ");
            switch (inputToSplit[0])
            {
                case "pop":
                    a.Append(result.Count == 0 ? -1 : result.Pop());
                    Console.WriteLine(a);
                    break;
                case "size":
                    a.Append(result.Count);
                    Console.WriteLine(a);
                    break;
                case "empty":
                    a.Append(result.Count == 0 ? 1 : 0);
                    Console.WriteLine(a);
                    break;
                case "top":
                    if (result.Count == 0)
                    {
                        a.Append(-1);
                        Console.WriteLine(a);
                    }
                    else
                    {
                        int s = result.Pop();
                        a.Append(s);
                        Console.WriteLine(a);
                        result.Push(s);
                    }
                    break;
                case "push":
                    result.Push(int.Parse(inputToSplit[1]));
                    break;
            }
        }
    }
}