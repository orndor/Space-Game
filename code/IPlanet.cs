using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    public interface IPlanet
    {
        string Name { get; set; } //Name of the plant

        decimal Multiplier { get; set; }


        //strings in demand will lookup product dictionary
        
        List<string> Supply();
        List<string> Demand();

        void GetDemand();
        void GetSupply();


    }
}
