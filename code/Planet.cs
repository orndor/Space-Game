using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    class Planet : IPlanet
    {

        public Planet()
        {
        }

        public string name { get; set; }  //Name of the plant
        public byte planetNum { get; set; }


        public string getPlanetName(byte planetNum)
        {
            switch (planetNum)
            {
                case 1:
                    name = "Earth";
                    break;
                case 2:
                    name = "Proxima Centauri 1";
                    break;
                case 3:
                    name = "Bernard' Star 1";
                    break;
            }
            return name;
        }
    }
}

