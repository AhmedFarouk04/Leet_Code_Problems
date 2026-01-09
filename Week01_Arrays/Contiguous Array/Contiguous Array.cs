using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Week01_Arrays.Contiguous_Array
{
    public  class Contiguous_Array
    {

        public int FindMaxLength(int[] nums)
        {
            Dictionary<int, int> firstIndex = new Dictionary<int, int>();

            int currentSum = 0;
            int maxLength = 0;

            firstIndex[0] = -1;

            for (int i = 0; i < nums.Length; i++)
            {
                currentSum += (nums[i] == 0) ? -1 : 1;

                if (firstIndex.ContainsKey(currentSum))
                {
                    int length = i - firstIndex[currentSum];
                    maxLength = Math.Max(maxLength, length);
                }
                else
                {
                    firstIndex[currentSum] = i;
                }
            }

            return maxLength;
        }

    }
}
