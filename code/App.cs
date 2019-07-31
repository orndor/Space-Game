using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    class App
    {
        
        void Run()
        {
            Product product = new Product();
            
            List<Product> products = new List<Product>();
            List<Product> inventories = new List<Product>();
            product.AddProducts(products);
            Shoping shoping = new Shoping(products);

            shoping.Buy(inventories, shoping.FindPrice("Gold"));

            shoping.Sell(inventories, shoping.FindPrice("Gold"));

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
