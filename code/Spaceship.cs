using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    class Spaceship : ISpaceship
    {
        public int Origin { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double WarpFactor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int ShipType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int GasTank { get => throw new NotImplementedException(); set => value = Origin * 10; }

        Spaceship()
        {
            Origin = 1;

        }
        public void ReFuel(double fuelPrice)
        {
            throw new NotImplementedException();
        }

        public void Travel()
        {
            throw new NotImplementedException();
        }
    }
}
