using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    class Shoping
    {
        List<Product> market = new List<Product>();
        public Shoping(List<Product> products)
        {
            market = products;
        }
        public Product FindPrice(string productName)
        {
            Product item=new Product() { ProductName = "Gold", Price = 100, Planet = 1 };
            foreach (Product i in market)
            {
                if ((i.ProductName == productName) && (i.Planet == Global.currentPlanet))
                {
                    item=i;
                    break;
                }
            }
            return item;
        }

        public void Buy(List<Product> inventory, Product item)
        {
            if (item.Price <= Global.money)
            {
                Global.money -= item.Price;
                inventory.Add(item);
            }
        }

        public void Sell(List<Product> inventory, Product item)
        {
            inventory.Remove(item);
            Global.money += item.Price;
        }

        public void PrintSellList(List<Product> inventory)
        {
            foreach (var item in inventory)
            {
                Console.WriteLine(item.ProductName);
            }
        }
    }
}
