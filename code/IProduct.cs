using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    interface IProduct
    {

        string ProductName { get; set; }

        decimal Price { get; set; }

        string SupplyPlanet { get; set; }

        string DemandPlanet { get; set; }


    }
}
