using System;

namespace BackJoon
{
    class BackJoon1157
    {
        static void Quest()
        {
            string input = Console.ReadLine().ToUpper();
            char[] inputToCharArry = input.ToCharArray();

            int[] alphabet = new int[26];
            for (int i = 0; i < inputToCharArry.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (inputToCharArry[i] == 'A' + j)
                    {
                        alphabet[j] += 1;
                    }
                }
            }
            int count = 0;
            bool a = true;
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (alphabet[i] == 0)
                {
                    continue;
                }

                else if (alphabet[count] < alphabet[i])
                {
                    count = i;
                }
            }
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (count != i && alphabet[count] == alphabet[i])
                {
                    a = false;
                }
            }
            char result = (char)('A' + count);
            if (a)
            {
                Console.Write($"{result}");
            }
            else
            {
                Console.Write("?");
            }
        }
    }
}