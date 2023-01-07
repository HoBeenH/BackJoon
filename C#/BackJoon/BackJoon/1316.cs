using System;

namespace BackJoon
{
    class BackJoon1316
    {
        static void Quest()
        {
            int testCase = int.Parse(Console.ReadLine());
            string[] word = new string[testCase];
            int result = 0;
            for (int i = 0; i < testCase; i++)
            {
                bool result2 = true;
                word[i] = Console.ReadLine();
                string[] wordToArry = new string[word[i].Length];
                for (int j = 0; j < word[i].Length; j++)
                {
                    wordToArry[j] = word[i].Substring(j, 1);
                }
                for (int j = 0; j < wordToArry.Length; j++)
                {
                    int index = 0;
                    string tempWord = word[i];
                    while (tempWord.Contains(wordToArry[j]))
                    {
                        index += 1;
                        tempWord = tempWord.Remove(tempWord.IndexOf(wordToArry[j]), 1);
                    }
                    int[] count = new int[index];
                    for (int k = 0; k < count.Length; k++)
                    {
                        count[k] = word[i].IndexOf(wordToArry[j]);
                        word[i] = word[i].Remove(word[i].IndexOf(wordToArry[j]), 1);
                    }
                    for (int k = 0; k < count.Length - 1; k++)
                    {
                        if (count[k] - count[k + 1] != 0)
                        {
                            result2 = false;
                            break;
                        }
                    }
                }
                if (result2)
                {
                    result += 1;
                }
            }
            Console.Write(result);
        }
    }
}