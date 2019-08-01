using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    class Spaceship : ISpaceship
    {
        static int Origin { get; set; }
        public double Age { get; set; }
        public string Name { get; set; }
        public double WarpFactor { get; set; } = GetWarp();
        public int GasTank { get; set; } = GetGasTank();
        public int Gas { get; set; } = GetGasTank();
        public double EarthToPC1 { get; set; } = 4.2441;
        public double EarthToBernard { get; set; } = 7.895;
        public double PC1ToBernard { get; set; } = 6.5;

        internal Spaceship(int origin, string name, int age = 18)
        {
            this.Age = age;
            this.Name = name;
            Origin = origin;
            
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

        public void Travel(int currentPlanet, int travelPlanet) //change current position
        {
            if(currentPlanet == 1 && travelPlanet == 2 || currentPlanet == 2 && travelPlanet == 1)
            {
                Age = Age + EarthToPC1 / WarpFactor;
                Global.currentPlanet = Convert.ToByte(travelPlanet);
                Gas = Gas - 1;
                return;
            }
            if (currentPlanet == 1 && travelPlanet == 3 || currentPlanet == 3 && travelPlanet == 1)
            {
                Age = Age + EarthToBernard / WarpFactor;
                Global.currentPlanet = Convert.ToByte(travelPlanet);
                Gas = Gas - 3;
                return;
            }
            if (currentPlanet == 2 && travelPlanet == 3 || currentPlanet == 3 && travelPlanet == 2)
            {
                Age = Age + PC1ToBernard / WarpFactor;
                Global.currentPlanet = Convert.ToByte(travelPlanet);
                Gas = Gas - 2;
                return;
            }
           
        }

        static double GetWarp()
        {
            if (Origin == 1)
            {
                return 2.0;
            }
            if (Origin == 2)
            {
                return 1.317;
            }
            else
            {
                return 1.621;
            }
        }

        static int GetGasTank()
        {
            int gT = Origin * 10;
            return gT;
        }

        public void TravelUI()
        {
            List<string> planets = new List<string>() { " Earth", " Proxima Centauri 1", " Bernard's Star" };

            ConsoleKeyInfo consoleKeyInfo;
            int position = Global.currentPlanet;

            for (int i = 0; i < planets.Count; i++)
            {

                if(i == position - 1)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine(planets[i]);
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine(planets[i]);
                }

            }

            while ((consoleKeyInfo = Console.ReadKey()).Key != ConsoleKey.Enter)
            {
                if(position == 4) { position = 0; }
                if (position == Global.currentPlanet)
                {
                    if (position == 3) { position = 0; }

                    position++;
                }
                    if (consoleKeyInfo.Key == ConsoleKey.DownArrow)
                    {
                        Console.Clear();
                        if (position == 1)
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.WriteLine(" Earth");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.WriteLine("Earth");
                        }
                        if (position == 2)
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.Write(" Proxima Centauri 1");
                            Console.ResetColor();
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine(" Proxima Centauri 1");
                        }
                        if (position == 3)
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.Write(" Bernard's Star 1");
                            Console.ResetColor();
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine(" Bernard's Star 1");
                        }

                    }
                   
                    
                    position++;
                
                
                
            }
            Travel(Global.currentPlanet, position);
            return;




        }

        public override string ToString()
        {
            return $"Origin {Origin} WarpFactor {WarpFactor} Current Age {Age}";
        }
    }
}
