using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Week03_stack.Largest_Rectangle_in_Histogram
{
    public  class LargestRectangleArea
    {
        public int Larges_tRectangle_Area(int[] heights)
        {
            Stack<int> stack = new Stack<int>();
            int maxArea = 0;
            int n = heights.Length;

            for (int i = 0; i <= n; i++)
            {
                int currHeight = (i == n) ? 0 : heights[i];

                while (stack.Count > 0 && currHeight < heights[stack.Peek()])
                {
                    int h = heights[stack.Pop()];
                    int right = i;
                    int left = stack.Count == 0 ? -1 : stack.Peek();
                    int width = right - left - 1;
                    maxArea = Math.Max(maxArea, h * width);
                }

                stack.Push(i);
            }

            return maxArea;
        }

    }
}
