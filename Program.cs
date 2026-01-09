using LeetCodePractice.Week01_Arrays.Best_Time_to_Buy_and_Sell_Stock;
using LeetCodePractice.Week01_Arrays.Longest_Substring_Without_Repeating_Characters;
using LeetCodePractice.Week01_Arrays.Subarray_Sum_Equals_K;
using LeetCodePractice.Week01_Arrays.TwoSum;
using System;

namespace LeetCodePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var sol = new SubarraySumEqualsK();

            int[] nums = { 1, 1, 1 };
            int k = 2;

            Console.WriteLine(sol.SubarraySum(nums, k)); // 2


        }
    }
}
