using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDDHomework_Day2
{
    public class PotterShoppingCart
    {
        private Dictionary<string, int> Cart = new Dictionary<string, int>();
        private int Price = 100;
        private List<double> Discount = new List<double>
        {
            0, 1, 0.95, 0.9, 0.8, 0.75
        };
        public void Add(string episode, int buyCount)
        {
            if(Cart.Any(a => a.Key == episode))
            {
                Cart[episode] += buyCount;
            }
            else
            {
                Cart.Add(episode, buyCount);
            }
        }

        public object CalculateTotalAmount()
        {
            double totalAmount = 0;

            var buyCounts = Cart.Select(a => a.Value);
            var maxCount = Cart.Max(a => a.Value);
            IEnumerable<int> excess = null;
            //取出目前最大數量
            //依數量跑迴圈，算出當下集數組合計算金額，
            //計算剩餘未計算數量後，紀錄在excess中
            while (maxCount > 0)
            {
                //第一次計算直接取出各集數數量
                if (excess == null) excess = buyCounts.Select(v => v);
                //算出目前有幾種書
                var countByBook = excess.Count(v => v > 0);

                for (int i = 0; i < countByBook; i++)
                {
                    //每種都取出一本計算折扣後金額，加總在totalAmount  
                    totalAmount += 1 * Price * Discount[countByBook];
                }

                //記錄未計算的數量
                excess = buyCounts.Select(v => v - 1).Where(v => v > 0);
                maxCount--;
            }

            return totalAmount;
        }
    }

    
}
