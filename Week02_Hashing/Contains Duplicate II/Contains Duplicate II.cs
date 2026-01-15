using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Week02_Hashing.Contains_Duplicate_II
{
    public  class Contains_Duplicate_II
    {

        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            Dictionary<int, int> lastIndex = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (lastIndex.ContainsKey(nums[i]))
                {
                    if (i - lastIndex[nums[i]] <= k)
                        return true;
                }

                lastIndex[nums[i]] = i;
            }

            return false;
        }

    }
}
