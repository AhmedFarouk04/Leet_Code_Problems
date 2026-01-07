using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Week01_Arrays.Best_Time_to_Buy_and_Sell_Stock
{
    public  class Best_Time_to_Buy_and_Sell_Stock
    {

        public int MaxProfit(int[] prices)
        {
            int minPrice = int.MaxValue;
            int maxProfit = 0;

            foreach (int price in prices)
            {
                if (price < minPrice)
                {
                    minPrice = price;
                }
                else
                {
                    maxProfit = Math.Max(maxProfit, price - minPrice);
                }
            }

            return maxProfit;
        }

    }
}
