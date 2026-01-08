using LeetCodePractice.Week01_Arrays.Best_Time_to_Buy_and_Sell_Stock;
using LeetCodePractice.Week01_Arrays.Longest_Substring_Without_Repeating_Characters;
using LeetCodePractice.Week01_Arrays.TwoSum;
using System;

namespace LeetCodePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var sol = new Longest_Substring_Without_Repeating_Characters();

            Console.WriteLine(sol.LengthOfLongestSubstring("abcabcbb")); // 3
            Console.WriteLine(sol.LengthOfLongestSubstring("bbbbb"));    // 1
            Console.WriteLine(sol.LengthOfLongestSubstring("pwwkew"));

        }
    }
}
