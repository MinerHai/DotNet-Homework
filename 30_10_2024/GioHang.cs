using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KtraApp
{
    public class ShoppingCart
    {
        private Dictionary<Product, int> cartItems = new Dictionary<Product, int>();

        public void AddProduct(Product product, int quantity)
        {
            if (cartItems.ContainsKey(product))
            {
                cartItems[product] += quantity;
            }
            else
            {
                cartItems[product] = quantity;
            }
        }

        public void RemoveProduct(Product product)
        {
            if (cartItems.ContainsKey(product))
            {
                cartItems.Remove(product);
            }
        }

        public decimal CalculateTotal()
        {
            return cartItems.Sum(item => item.Key.Price * item.Value);
        }

        public int CalculateTotalQuantity()
        {
            return cartItems.Sum(item => item.Value);
        }

        public Dictionary<Product, int> GetCartItems()
        {
            return cartItems;
        }

        public void Clear()
        {
            cartItems.Clear();
        }
    }
}