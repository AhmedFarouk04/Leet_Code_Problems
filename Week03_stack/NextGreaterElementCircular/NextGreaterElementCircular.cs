using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Week03_stack.NewFolder
{
    public class NextGreaterElementCircular
    {
        public int[] NextGreaterElements(int[] nums)
        {
            int n = nums.Length;
            int[] result = new int[n];
            Array.Fill(result, -1);

            Stack<int> stack = new Stack<int>(); // indices

            for (int i = 0; i < 2 * n; i++)
            {
                int idx = i % n;

                while (stack.Count > 0 && nums[idx] > nums[stack.Peek()])
                {
                    int prevIndex = stack.Pop();
                    result[prevIndex] = nums[idx];
                }

               // Add in first iteration
                if (i < n)
                {
                    stack.Push(idx);
                }
            }

            return result;
        }

    }
}
