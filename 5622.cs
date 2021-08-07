using System;

namespace BackJoon
{
    class BackJoon5622
    {
        static void Quest()
        {
            string number = Console.ReadLine();
            string[] numToArry = new string[number.Length];
            for (int i = 0; i < numToArry.Length; i++)
            {
                numToArry[i] = number.Substring(i, 1);
            }
            int result = 0;
            for (int i = 0; i < numToArry.Length; i++)
            {
                if (numToArry[i] == "A" || numToArry[i] == "B" || numToArry[i] == "C")
                {
                    result += 3;
                }
                else if (numToArry[i] == "D" || numToArry[i] == "E" || numToArry[i] == "F")
                {
                    result += 4;
                }
                else if(numToArry[i] == "G" || numToArry[i] == "H" || numToArry[i] == "I")
                {
                    result += 5;
                }
                else if(numToArry[i] == "J" || numToArry[i] == "K" || numToArry[i] == "L")
                {
                    result += 6;
                }
                else if(numToArry[i] == "M" || numToArry[i] == "N" || numToArry[i] == "O")
                {
                    result += 7;
                }
                else if(numToArry[i] == "P" || numToArry[i] == "Q" || numToArry[i] == "R" || numToArry[i] == "S")
                {
                    result += 8;
                }
                else if(numToArry[i] == "T" || numToArry[i] == "U" || numToArry[i] == "V")
                {
                    result += 9;
                }
                else if(numToArry[i] == "W" || numToArry[i] == "X" || numToArry[i] == "Y" || numToArry[i] == "Z")
                {
                    result += 10;
                }
            }
            Console.Write(result);
        }
    }
}
