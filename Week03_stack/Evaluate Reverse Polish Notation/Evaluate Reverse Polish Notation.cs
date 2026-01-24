using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Week03_stack.Evaluate_Reverse_Polish_Notation
{
    public class Evaluate_Reverse_Polish_Notation
    {
        public int EvalRPN(string[] tokens)
        {
            Stack<int> stack = new Stack<int>();

            foreach (string token in tokens)
            {
                if (token == "+" || token == "-" || token == "*" || token == "/")
                {
                    int b = stack.Pop();
                    int a = stack.Pop();

                    if (token == "+") stack.Push(a + b);
                    else if (token == "-") stack.Push(a - b);
                    else if (token == "*") stack.Push(a * b);
                    else stack.Push(a / b);
                }
                else
                {
                    stack.Push(int.Parse(token));
                }
            }

            return stack.Pop();
        }

    }
}
