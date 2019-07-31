using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    interface IPlanet
    {

        string name { get; set; }  //Name of the plant
        byte planetNum { get; set; }
        string getPlanetName(byte planetNum);
    }

}
