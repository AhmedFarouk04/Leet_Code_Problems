using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Week03_stack.DailyTemperatures
{
    public  class DailyTemperatures
    {

        public int[] Daily_Temperatures(int[] temperatures)
        {
            int n = temperatures.Length;
            int[] answer = new int[n];
            Stack<int> stack = new Stack<int>(); // store indices

            for (int i = 0; i < n; i++)
            {
                while (stack.Count > 0 && temperatures[i] > temperatures[stack.Peek()])
                {
                    int prevDay = stack.Pop();
                    answer[prevDay] = i - prevDay;
                }

                stack.Push(i);
            }

            return answer;
        }

    }
}
