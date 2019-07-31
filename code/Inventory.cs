using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    class Inventory : IInventory
    {
        //List<Product> products = new List<Product> { };
        //public List<Product> Products { get => products; set => products=value; }
        public void Buy(List<Product> products, string item)
        {
            products.Add(new Product() { ProductName = "Gold", Price = 100, Planet = 1 });
        }

        public void Sell(List<Product> products)
        {
            products.Remove(new Product() { ProductName = "Gold", Price = 100, Planet = 1 });
        }

       
    }
}
