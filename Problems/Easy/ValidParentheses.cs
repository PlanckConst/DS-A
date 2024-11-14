using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Easy
{
    public class ValidParentheses
    {
        public static bool IsValid(string s)
        {
            if (s.Length % 2 != 0) return false;

            char[] stack = new char[s.Length];
            int top = -1; // Keeps track of the top of the "stack" in the array

            foreach (var character in s)
            {
                switch (character)
                {
                    case '(':
                        stack[++top] = ')';
                        break;
                    case '{':
                        stack[++top] = '}';
                        break;
                    case '[':
                        stack[++top] = ']';
                        break;
                    case ')':
                    case '}':
                    case ']':
                        if (top == -1 || stack[top--] != character) return false;
                        break;
                    default:
                        break;
                }
            }

            return top == -1;
        }
    }
}
