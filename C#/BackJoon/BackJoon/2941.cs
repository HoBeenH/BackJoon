using System;

namespace BackJoon
{
    class BackJoon2941
    {
        static void Quest()
        {
            string croAlpabet = Console.ReadLine();
            string[] croNewAlpha = new string[8]
            {"c=", "c-", "dz=", "d-","lj", "nj", "s=", "z="};
            for (int i = 0; i < croNewAlpha.Length; i++)
            {
                if (croAlpabet.IndexOf(croNewAlpha[i]) != -1)
                {
                    croAlpabet = croAlpabet.Replace(croNewAlpha[i], "A");
                }
            }
            Console.Write(croAlpabet.Length);
        }
    }
}