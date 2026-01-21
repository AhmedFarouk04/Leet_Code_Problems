using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Week03_stack.NextGreaterElement
{
    public class NextGreaterElement
    {
        public int[] Next_Greater_Element(int[] nums1, int[] nums2)
        {
            Stack<int> stack = new Stack<int>();
            Dictionary<int, int> map = new Dictionary<int, int>();

            foreach (int num in nums2)
            {
                while (stack.Count > 0 && num > stack.Peek())
                {
                    map[stack.Pop()] = num;
                }
                stack.Push(num);
            }

            while (stack.Count > 0)
            {
                map[stack.Pop()] = -1;
            }

            int[] result = new int[nums1.Length];
            for (int i = 0; i < nums1.Length; i++)
            {
                result[i] = map[nums1[i]];
            }

            return result;
        }

    }
}
