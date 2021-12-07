using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackJoon15649
{
    public class BJ
    {
        private static int small = 0;
        private static int big = 0;
        private static readonly Stack<char> bracket = new Stack<char>();

        public static void Main(string[] args)
        {
            while (true)
            {
                var _input = Console.ReadLine().ToCharArray();
                if (_input[0] == '.')
                    break;
                var _fact = _input.All(Find);
                if (bracket.Count != 0)
                {
                    _fact = false;
                }

                Console.Write(_fact ? "yes\n" : "no\n");
                bracket.Clear();
                small = 0;
                big = 0;
            }
        }

        private static bool Find(char c)
        {
            switch (c)
            {
                case '(':
                    ++small;
                    bracket.Push(c);
                    break;
                case '[':
                    ++big;
                    bracket.Push(c);
                    break;
                default:
                    if (c == ')' || c == ']')
                    {
                        if (bracket.Count == 0)
                            return false;
                        switch (c)
                        {
                            case ')':
                                if (small <= 0 || bracket.Peek() != '(')
                                    return false;
                                --small;
                                bracket.Pop();
                                break;

                            case ']':
                                if (big <= 0 || bracket.Peek() != '[')
                                    return false;
                                --big;
                                bracket.Pop();
                                break;
                        }
                    }

                    break;
            }

            return true;
        }
    }
}