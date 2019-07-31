using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    public interface ISpaceship
    {
        
        int Origin { get; set; } //1 Earth, 2 Bernard's Star B, 3 Proxima Centauri 1

        double Age { get; set; } //starts at 18-years for each player

        string Name { get; set; } //username

        double WarpFactor { get; set; } // Small Warp factor = 2.0, Medium = 1.621, Large = 1.317

        int ShipType { get; set; }//feed origin and return small medium or large

        int GasTank { get; set; }// Small = 10, Medium = 20, Large = 30

        int Gas { get; set; }

        double EarthToPC1 { get; set; }
        double EarthToBernard { get; set; }
        double PC1ToBernard { get; set; }
        

        void ReFuel(int fuelPrice); //Cool functions that ensure 100 or above 0; change fuel property; for i statement about gas maxing out, minus money

        void Travel(int currentPlanet, int travelPlanet);//if fuel = 0, environment.exit(0); age change, spend gas, change location


    }
}
