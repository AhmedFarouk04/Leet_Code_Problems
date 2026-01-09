using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Week01_Arrays.Subarray_Sum_Equals_K
{
    public class SubarraySumEqualsK
    {
        public int SubarraySum(int[] nums, int k)
        {
            Dictionary<int, int> prefixCount = new Dictionary<int, int>();
            prefixCount[0] = 1;

            int currentSum = 0;
            int count = 0;

            foreach (int num in nums)
            {
                currentSum += num;

                if (prefixCount.ContainsKey(currentSum - k))
                {
                    count += prefixCount[currentSum - k];
                }

                if (!prefixCount.ContainsKey(currentSum))
                    prefixCount[currentSum] = 0;

                prefixCount[currentSum]++;
            }

            return count;
        }

    }
}
