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
            var ep1Count = Cart.First(item => item.Key == "episode1").Value;
            return ep1Count * Price;
        }
    }

    
}
