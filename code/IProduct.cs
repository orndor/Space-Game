using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    interface IProduct
    {
        string ProductName { get; set; }
        int Price { get; set; }
        byte Planet { get; set; }
    }
}
