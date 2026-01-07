using LeetCodePractice.Week01_Arrays.Best_Time_to_Buy_and_Sell_Stock;
using LeetCodePractice.Week01_Arrays.TwoSum;
using System;

namespace LeetCodePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Best_Time_to_Buy_and_Sell_Stock();

            int[] prices = { 7, 1, 5, 3, 6, 4 };

            Console.WriteLine(solution.MaxProfit(prices)); // 5

        }
    }
}
