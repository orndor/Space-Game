using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    class LukeApp
    {
        void Run()
        {
            Planet earth = new Planet(1);
            bool userLoggedIn = true;

            while(userLoggedIn)
            {
                Console.Write("Enter Name: ");
                string userName = Console.ReadLine();

                Spaceship earthShip = new Spaceship(earth.PlanetNum, userName, earth.PlanetNum);
                Console.WriteLine(earthShip.ToString());
                userLoggedIn = false;

            }
            
            

        }
    }
}
