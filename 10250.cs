using System;
using System.Text;
class BackJoon10250
{
    static void Quest()
    {
        int testCase = int.Parse(Console.ReadLine());
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < testCase; i++)
        {
            string[] input = Console.ReadLine().Split(" ");
            int floor = int.Parse(input[0]);
            int room = int.Parse(input[1]);
            int point = int.Parse(input[2]);

            int pointFloor = point % floor;
            int pointRoom = point / floor;
            int temp = point % floor;
            if (temp == 0)
            {
                result.Append($"{floor}{pointRoom.ToString("D2")}\n");
            }
            else if (temp != 0)
            {
                result.Append($"{pointFloor}{(pointRoom + 1).ToString("D2")}\n");
            }
        }
        Console.Write(result);
    }
}