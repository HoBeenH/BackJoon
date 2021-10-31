using System;
using System.Linq;  
using System.Text;

namespace BackJoon15649
{
    internal class BJ
    {
        private static bool[] m_IsTrue;
        private static int[] m_Result;
        private static int[] m_Input;
        private static StringBuilder m_SB;

        public static void Main(string[] args)
        {
            m_Input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            m_SB = new StringBuilder();
            m_Result = new int[m_Input[0]];
            m_IsTrue = new bool[m_Input[0] + 1];
            
            Cal(0);
        }

        private static void Cal(int n)
        {
            if (n == m_Input[1])
            {
                for (var i = 0; i < n; i++)
                {
                    m_SB.Append($"{m_Result[i]}" + " ");
                }
                Console.WriteLine(m_SB);
                m_SB.Clear();
                
                return;
            }

            for (var i = 1; i <= m_Input[0]; i++)
            {
                if (m_IsTrue[i])
                    continue;
                m_IsTrue[i] = true;
                m_Result[n] = i;
                Cal(n + 1);
                m_IsTrue[i] = false;
            }
        }
    }
}