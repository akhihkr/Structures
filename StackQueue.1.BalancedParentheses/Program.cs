using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue._1.BalancedParentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input: "()"
            //Output: true
            Console.WriteLine(isValid("()"));

            //Input: "())"
            //Output: false
            //Explanation: There is 1 unmatched closing paren
            Console.WriteLine(isValid("())"));

        }

        public static bool isValid(string s)
        {

            if (s.Length < 1)
                return false;

            Dictionary<char, char> openCloseMap = new Dictionary<char, char>();
            openCloseMap.Add('(', ')');
            openCloseMap.Add('[', ']');
            openCloseMap.Add('{', '}');

            HashSet<char> openParentheses = new HashSet<char>() { '(', '[', '{' };
            HashSet<char> closeParentheses = new HashSet<char>() { ')', ']', '}' };

            Stack<char> parenStack = new Stack<char>();

            foreach (char c in s)
            {
                //push if open parentheses
                if (openParentheses.Contains(c))
                {
                    parenStack.Push(openCloseMap[c]);
                }
                else if (closeParentheses.Contains(c))//pop if close parenthses
                {
                    if (parenStack.Count < 1)
                        return false;
                    if (parenStack.Pop() != c)
                    {
                        return false;
                    }
                }
            }

            if (parenStack.Count > 0)
                return false;

            return true;

        }
    }
}
