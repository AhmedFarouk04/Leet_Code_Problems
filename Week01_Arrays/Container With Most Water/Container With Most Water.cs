using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Week01_Arrays.Container_With_Most_Water
{
    public class Container_With_Most_Water
    {
        public int MaxArea(int[] height)
        {
            int left = 0;
            int right = height.Length - 1;
            int maxArea = 0;

            while (left < right)
            {
                int width = right - left;
                int currentHeight = Math.Min(height[left], height[right]);
                int area = width * currentHeight;

                maxArea = Math.Max(maxArea, area);

                // Move the pointer with the smaller height
                if (height[left] < height[right])
                    left++;
                else
                    right--;
            }

            return maxArea;
        }

    }
}
