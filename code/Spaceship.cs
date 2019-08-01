using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    class Spaceship : ISpaceship
    {
        public int Origin { get; set; }
        public double Age { get; set; }
        public string Name { get; set; }
        public int ShipType { get; set; }
        public double WarpFactor { get => WarpFactor; set => GetWarp(); }
        public int GasTank { get => GasTank; set => value = Origin * 10; }
        public int Gas { get => Gas; set => value = GasTank; }
        public double EarthToPC1 { get => EarthToPC1; set => value = 4.2441; }
        public double EarthToBernard { get => EarthToBernard; set => value = 7.895; }
        public double PC1ToBernard { get => PC1ToBernard; set => value = 6.5; }

        internal Spaceship(int origin, string name, int age = 18)
        {
            this.Age = age;
            this.Name = name;
            this.Origin = origin;
            this.ShipType = this.Origin;
            

        }
        public void ReFuel(int fuelPrice) //from planet
        {
            if(GasTank == Gas){ Console.WriteLine("Gas is Full"); return;}
            for(int i = 0; i <= GasTank; i++)
            {
                Global.money -= fuelPrice;
                Gas++;
            }
            Console.WriteLine("Gas is full");

        }

        public void Travel(int currentPlanet, int travelPlanet)
        {
            if(currentPlanet == 1 && travelPlanet == 2 || currentPlanet == 2 && travelPlanet == 1)
            {
                Age = Age + EarthToPC1 / WarpFactor;
                return;
            }
            if (currentPlanet == 1 && travelPlanet == 3 || currentPlanet == 3 && travelPlanet == 1)
            {
                Age = Age + EarthToBernard / WarpFactor;
                return;
            }
            if (currentPlanet == 2 && travelPlanet == 3 || currentPlanet == 3 && travelPlanet == 2)
            {
                Age = Age + PC1ToBernard / WarpFactor;
                return;
            }
           
        }

        double GetWarp()
        {
            if (ShipType == 1)
            {
                return 2.0;
            }
            if (ShipType == 2)
            {
                return 1.317;
            }
            else
            {
                return 1.621;
            }
        }

        public override string ToString()
        {
            return $"ShipType {ShipType} WarpFactor {WarpFactor}";
        }
    }
}
