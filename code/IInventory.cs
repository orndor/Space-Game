using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;


namespace Space_Game
{
    interface IInventory
    {
        
        //List<Product> Products { get; set; }
        void Buy(List<Product> inventory, string item);
        void Sell(List<Product> inventory);
    }
}
