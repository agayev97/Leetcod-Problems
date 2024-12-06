using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidParentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("Test Case 1: ()");
            Console.WriteLine(program.IsValid("()")); // Çıktı: True

            Console.WriteLine("Test Case 2: ()[]{}");
            Console.WriteLine(program.IsValid("()[]{}"));

            Console.WriteLine("Test Case 3: (]");
            Console.WriteLine(program.IsValid("(]"));

            Console.WriteLine("Test Case 4: ([])");
            Console.WriteLine(program.IsValid("([])"));

            Console.ReadKey();

        }
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    char top = stack.Pop();
                    if ((c == ')' && top != '(') ||
                        (c == '}' && top != '{') ||
                        (c == ']' && top != '['))
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }
    }

}
