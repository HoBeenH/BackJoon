using System;

namespace BackJoon
{
    class BackJoon1110
    {
        static void Main()
        {
            int count = 1;
            string input = Console.ReadLine();
            string ok = input;
            while (true)
            {
                char[] temp3 = input.ToCharArray();
                string[] temp = new string[temp3.Length];
                for (int i = 0; i < temp.Length; i++)
                {
                    temp[i] = temp3[i].ToString();
                }
                string result;
                int[] num = new int[2];
                int temp2;

                if (temp.Length == 2)
                {
                    for (int i = 0; i < temp.Length; i++)
                    {
                        num[i] = int.Parse(temp[i]);
                    }

                    temp2 = num[0] + num[1];
                }
                else
                {
                    num[0] = 0;
                    num[1] = int.Parse(temp[0]);

                    temp2 = num[1];
                }

                if (temp2 < 10)
                {
                    result = temp[1].ToString() + temp2.ToString();
                }
                else
                {
                    string a = temp2.ToString();
                    char[] b = a.ToCharArray();
                    string[] c = new string[b.Length];
                    for (int i = 0; i < c.Length; i++)
                    {
                        c[i] = b[i].ToString();
                    }
                    result = temp[1] + c[1];
                }
                if (ok == result)
                {
                    Console.Write(count);
                    break;
                }
                else
                {
                    input = result;
                }
                count++;
            }
        }
    }
}