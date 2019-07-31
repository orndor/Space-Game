using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    class LukeApp
    {
        string userName;
        string origin;
        int originInt;
        void Run()
        {
            //
            Planet earth = new Planet(1);
            bool userLoggedIn = true;

            while(userLoggedIn)
            {
                if(userName == null)
                {
                    Console.Write("Enter Name: ");
                    userName = Console.ReadLine();
                    
                }

                try
                {
                    Console.Write("1: Earth, 2: PC1, 3: Bernard's Star");
                    origin = Console.ReadLine();
                    originInt = Convert.ToInt32(origin);
                }
                catch
                {
                    Console.WriteLine("Not a number");
                    userLoggedIn = false;
                }

                if (!userLoggedIn)
                {
                    switch(originInt)
                    {
                        case 1:
                            Spaceship earthShip = new Spaceship(earth.PlanetNum, userName, earth.PlanetNum);
                            Console.WriteLine(earthShip.ToString());
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                    }
                
                    
                }
                

            }
            
            

        }
    }
}
