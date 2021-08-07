using System;
class BackJoon1550
{
    static void Quest()
    {
        string input = Console.ReadLine();
        string result = Convert.ToInt32(input, 16).ToString();
        Console.Write(result);
    }
}