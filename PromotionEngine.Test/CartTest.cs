using PromotionEngineAdapter;
using System;
using Xunit;
using System.Collections.Generic;

namespace PromotionEngine.Test
{
    public class CartTest
    {
        [Fact]
        public void CART_TOTAL_ORDER_ONE_SCCUESS()
        {
            // Arrange
            List<Cart> carts = new List<Cart>();
            var num = "A";
            var expectedPrice = 50;
            // Act  
            Cart cart = new Cart(num);
            carts.Add(cart);
            var totalPrice = cart.GetTotalPrice();

            //Assert  
            Assert.Equal(expectedPrice, totalPrice);
        }

        [Fact]
        public void CART_TOTAL_ORDER_ONE_FAILD()
        {
            // Arrange
            List<Cart> carts = new List<Cart>();
            var num = "B";
            var expectedPrice = 50;
            // Act  
            Cart cart = new Cart(num);
            carts.Add(cart);
            var totalPrice = cart.GetTotalPrice();

            //Assert  
            Assert.NotEqual(expectedPrice, totalPrice);
        }
    }
}
