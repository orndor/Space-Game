using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;


namespace Space_Game
{
    interface IInventory
    {
        decimal Money { get; set; }

        int Gas { get; set; }

        List<Product> Products(); //anything

        void Buy();

        void Sell();
    }
}
