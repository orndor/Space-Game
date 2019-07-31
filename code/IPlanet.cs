using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    interface IPlanet
    {
        byte PlanetNum { get; set; }
        string PlanetName { get; set; }
        string GetPlanetName(byte PlanetNum);
    }

}
