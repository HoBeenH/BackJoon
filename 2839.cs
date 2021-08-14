using System;
class BackJoon2839
{
    static void Quest()
    {
        int sugar = int.Parse(Console.ReadLine());
        int count = 0;
        while (sugar >= 0)
        {
            if (sugar % 5 == 0)
            {
                Console.Write((sugar / 5) + count);
                return;
            }
            sugar -= 3;
            count++;
        }
        Console.Write(-1);
    }
}