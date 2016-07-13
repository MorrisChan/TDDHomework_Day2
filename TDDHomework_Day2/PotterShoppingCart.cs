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
            var countByBook = Cart.Count();
            double totalAmount = 0;

            foreach (var item in Cart)
            {
                totalAmount += item.Value * Price * Discount[countByBook];
            }

            return totalAmount;
        }
    }

    
}
