using System;

namespace BackJoon
{
    class BackJoon10809
    {
        static void Quest()
        {
            char[] input = Console.ReadLine().ToUpper().ToCharArray();
            int[] alphabet = new int[26];
            for (int i = 0; i < alphabet.Length; i++)
            {
                alphabet[i] = -1;
            }

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (alphabet[j] != -1)
                    {
                        continue;
                    }
                    if (input[i] == (char)( 65 + j ) )
                    {
                        alphabet[j] = i;
                    }
                }
            }

            foreach (var result in alphabet)
            {
                Console.Write($"{result} ");
            }
        }
    }
}