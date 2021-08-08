using System;

namespace BackJoon
{
    class BackJoon2292
    {
        static void Quest()
        {
            int findRoomNumber = int.Parse(Console.ReadLine());
            int firstRoom = 1;
            int fixRoom = 6;
            int result;
            if (findRoomNumber == 1)
            {
                result = 1;
                Console.Write(result);
            }
            else
            {
                for (int i = 1; ; i++)
                {
                    if (firstRoom < findRoomNumber && findRoomNumber <= firstRoom + (fixRoom * i))
                    {
                        result = i + 1;
                        Console.Write(result);
                        return;
                    }
                    firstRoom += fixRoom * i;
                }
            }
        }
    }
}