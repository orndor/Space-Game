using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    interface IPlanet
    {

        string Name { get; set; }  //Name of the plant
        byte PlanetNum { get; set; }
        string GetPlanetName(byte PlanetNum);
    }

}
