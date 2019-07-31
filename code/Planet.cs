using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    class Planet : IPlanet
    {

        public byte PlanetNum { get; set; }
        public string PlanetName { get; set; }
        public Planet(byte planetNum = 1 )
        {
            this.PlanetName = GetPlanetName(planetNum);
            this.PlanetNum = planetNum;
        }


        public string GetPlanetName(byte PlanetNum)
        {

            switch (PlanetNum)
            {
                case 1:
                    PlanetName = "Earth";
                    break;
                case 2:
                    PlanetName = "Proxima Centauri 1";
                    break;
                case 3:
                    PlanetName = "Bernard's Star 1";
                    break;
            }
            return PlanetName;
        }
    }
}

