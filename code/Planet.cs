using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    class Planet : IPlanet
    {

        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }  //Name of the plant
        public decimal Multiplier { get => throw new NotImplementedException(); set => throw new NotImplementedException(); } //This is the amount of we multiple the cost of an item on an in-demand planet


        //strings in demand will lookup product dictionary
        public Dictionary<string, decimal> demand()
        {
            throw new NotImplementedException(); //A list for holding the name of the product from the Product object
        }
        public Dictionary<string, decimal> supply()
        {
            throw new NotImplementedException(); //A list for holding the name of the product from the Product object
        }

        public void GetDemand()
        {
            throw new NotImplementedException();
        }
        public void GetSupply()
        {
            throw new NotImplementedException();
        }
    }
}
