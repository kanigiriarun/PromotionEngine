using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngineAdapter
{
    public static class CartExtension
    {
        public static int GetTotalPrice(this List<Cart> carts)
        {
            int counterofA = 0;
            int priceofA = 50;
            int counterofB = 0;
            int priceofB = 30;
            int counterofC = 0;
            int priceofC = 20;
            int counterofD = 0;
            int priceofD = 15;
            foreach (Cart cart in carts)
            {
                if (cart.Id == "A" || cart.Id == "a")
                {
                    counterofA = counterofA + 1;
                }
                if (cart.Id == "B" || cart.Id == "b")
                {
                    counterofB = counterofB + 1;
                }
                if (cart.Id == "C" || cart.Id == "c")
                {
                    counterofC = counterofC + 1;
                }
                if (cart.Id == "D" || cart.Id == "d")
                {
                    counterofD = counterofD + 1;
                }
            }
            int totalPriceofA = (counterofA / 3) * 130 + (counterofA % 3 * priceofA);
            int totalPriceofB = (counterofB / 2) * 45 + (counterofB % 2 * priceofB);
            int totalPriceofC = (counterofC * priceofC);
            int totalPriceofD = (counterofD * priceofD);
            return totalPriceofA + totalPriceofB + totalPriceofC + totalPriceofD;

        }
    }
}
