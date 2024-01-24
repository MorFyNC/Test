using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalitySpace
{
    public static class Functionality
    {
        private static Stack<char> stack = new Stack<char>();
        private static Dictionary<char, char> chars = new Dictionary<char, char>
        {
            {'(', ')' },
            {'[', ']' },
            {'{', '}' }
        };

        public static bool CheckOrder(string input)
        {
            foreach (char c in input)
            {
                if (chars.ContainsKey(c))
                {
                    stack.Push(c);
                }
                else if (chars.ContainsValue(c))
                {
                    if (stack.Count == 0 || chars[stack.Pop()] != c)
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }
    }
}
