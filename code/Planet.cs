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

        public string Name { get => Name; set => Name = GetPlanetName(PlanetNum); }  //Name of the plant
        public byte PlanetNum { get; set; }


        public string GetPlanetName(byte PlanetNum)
        {
            switch (PlanetNum)
            {
                case 1:
                    Name = "Earth";
                    break;
                case 2:
                    Name = "Proxima Centauri 1";
                    break;
                case 3:
                    Name = "Bernard' Star 1";
                    break;
            }
            return Name;
        }
    }
}

