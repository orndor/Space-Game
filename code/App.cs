using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    class App
    {
        
        public void Run()
        {
            Product product = new Product();
            
            List<Product> products = new List<Product>();
            List<Product> inventories = new List<Product>();
            product.AddProducts(products);

            Menu menu = new Menu();
            menu.KeyCatch(inventories, products);
            //foreach (Product item in products)
            //{
            //    if ((item.ProductName == "Gold") && (item.Planet == Global.currentPlanet))
            //    {
            //        inventory.Buy(inventories, item);
            //    }
            //}

            //Product EarthGold = new Product("Earth Gold", 100);
            //Inventory.Products.Add(EarthGold);



        }
    }
}
