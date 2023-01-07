using System;
using System.Text;

namespace BackJoon
{
    class BackJoon1002
    {
        static void Quest()
        {
            StringBuilder result = new StringBuilder();
            int testCase = int.Parse(Console.ReadLine());

            for (int i = 0; i < testCase; i++)
            {

                string[] vectors = Console.ReadLine().Split(" ");
                int x1 = int.Parse(vectors[0]);
                int y1 = int.Parse(vectors[1]);
                int r1 = int.Parse(vectors[2]);
                int x2 = int.Parse(vectors[3]);
                int y2 = int.Parse(vectors[4]);
                int r2 = int.Parse(vectors[5]);

                int disPow = (int)MathF.Pow(x2 - x1, 2) + (int)MathF.Pow(y2 - y1, 2);

                if (x1 == x2 && y1 == y2 && r1 == r2)
                {
                    result.Append($"{-1}\n");
                }

                else if (disPow > MathF.Pow(r2 + r1, 2))
                {
                    result.Append($"{0}\n");
                }

                else if (disPow < MathF.Pow(r2 - r1, 2))
                {
                    result.Append($"{0}\n");
                }

                else if (disPow == MathF.Pow(r2 + r1, 2))
                {
                    result.Append($"{1}\n");
                }

                else if (disPow == MathF.Pow(r2 - r1, 2))
                {
                    result.Append($"{1}\n");
                }

                else
                {
                    result.Append($"{2}\n");
                }
            }
            Console.Write(result);
        }
    }
}