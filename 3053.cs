using System;
using System.Text;
class BackJoon3053
{
    static void Quest()
    {
        int input = int.Parse(Console.ReadLine());

        double uclid = ((input * input) * Math.PI);
        double taxi = 2 * input * input;
        Console.Write($"{uclid.ToString("f6")}\n{taxi.ToString("f6")}");
    }
}