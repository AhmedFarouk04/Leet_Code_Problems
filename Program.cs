using System;
using LeetCodePractice.Week01_Arrays.TwoSum;

namespace LeetCodePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            var result = solution.TwoSum(nums, target);

            Console.WriteLine($"Result: [{result[0]}, {result[1]}]");
        }
    }
}
