using System;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var nums = (Console.ReadLine().ToCharArray().Select(num => num - 48).OrderBy(i => i).ToArray());
            var result = new StringBuilder();
            for (var i = nums.Length - 1; i >= 0; i--)
            {
                result.Append(nums[i]);
            }

            Console.Write(result);
        }
    }
}