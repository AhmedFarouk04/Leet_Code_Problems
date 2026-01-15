using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Week02_Hashing.Contains_Duplicate_III
{
    public  class Contains_Duplicate_III
    {
        
            public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t)
            {
                if (k <= 0 || t < 0)
                    return false;

                SortedSet<long> window = new SortedSet<long>();

                for (int i = 0; i < nums.Length; i++)
                {
                    long current = nums[i];

                    long lowerBound = current - t;

                    var range = window.GetViewBetween(lowerBound, current + t);

                    if (range.Count > 0)
                        return true;

                    window.Add(current);

                    if (i >= k)
                        window.Remove(nums[i - k]);
                }

                return false;
            }

        }
    }

