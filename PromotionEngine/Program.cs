using PromotionEngineAdapter;
using System;
using System.Collections.Generic;

namespace PromotionEngine
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Cart> carts = new List<Cart>();

            Console.WriteLine("Total number of orders");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Enter the type of product(for example A,B,C or D)");
                string type = Console.ReadLine();
                Cart cart = new Cart(type);
                carts.Add(cart);
            }

            int totalPrice = carts.GetTotalPrice();
            Console.WriteLine(totalPrice);
            Console.ReadLine();
        }
    }
}
