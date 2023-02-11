using System.IO;
using System.Text;
using static System.Console;

namespace BackJoon
{
    public class Q_25501
    {
        public static void EntryPoint(string[] args)
        {
            using (var _sr = new StreamReader(OpenStandardInput()))
            {
                var _len = int.Parse(_sr.ReadLine());
                var _sb = new StringBuilder();
                var _pi = new Palindrome();

                for (var i = 0; i < _len; i++)
                {
                    _sb.AppendLine($"{_pi.GetResult(_sr.ReadLine())} {_pi.Count.ToString()}");
                    _pi.Clear();
                }
                
                WriteLine(_sb.ToString());
            }
        }
        
        private class Palindrome
        {
            private char[] m_StrToChar;
            public int Count { get; private set; } = 1;

            public void Clear()
            {
                m_StrToChar = null;
                Count = 1;
            }

            public string GetResult(string arg)
            {
                m_StrToChar = arg.ToCharArray();
                return BooleanToStr(IsPalindrome(0, m_StrToChar.Length - 1));
            }

            private bool IsPalindrome(in int l, in int r)
            {
                if (l >= r)
                    return true;

                if (m_StrToChar[l] != m_StrToChar[r])
                    return false;

                Count++;
                return IsPalindrome(l + 1, r - 1);
            }
        }
        
        private static string BooleanToStr(bool arg) => arg ? "1" : "0";
    }
}