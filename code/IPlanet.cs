using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    interface IPlanet
    {
        string Name { get; set; } //Name of the plant

        decimal Multiplier { get; set; }


        //strings in demand will lookup product dictionary
        Dictionary<string, decimal> demand(); //A list for holding the name of the product from the Product object
        Dictionary<string, decimal> supply(); //A list for holding the name of the product from the Product object

        void GetDemand();
        void GetSupply();


    }
}
