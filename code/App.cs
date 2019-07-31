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
            List<Product> inventory = new List<Product>();
            product.AddProducts(products);
            
            //Product EarthGold = new Product("Earth Gold", 100);
            //Inventory.Products.Add(EarthGold);



        }
    }
}
