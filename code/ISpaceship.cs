using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    public interface ISpaceship
    {


        double EarthToPC1 { get; set; }
        double EarthToBernard { get; set; }
        double PC1ToBernard { get; set; }

        double travelMultiplier { get; set; }
        

        void ReFuel(); //Cool functions that ensure 100 or above 0; change fuel property; for i statement about gas maxing out, minus money

        void Travel(int currentPlanet, int travelPlanet);//if fuel = 0, environment.exit(0); age change, spend gas, change location


    }
}
