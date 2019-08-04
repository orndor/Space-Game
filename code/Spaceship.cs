using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    class Spaceship : ISpaceship
    {
        public double WarpFactor { get; set; }
        public double travelMultiplier { get; set; }
        public double EarthToPC1 { get; set; } = 4.2441;
        public double EarthToBernard { get; set; } = 7.895;
        public double PC1ToBernard { get; set; } = 6.5;

        internal Spaceship()
        {
            WarpFactor = GetWarp();
            travelMultiplier = GetTravelMultiplier();

        }
        public void ReFuel() //from planet
        {
            int fuelPrice = Planet.GetFuel(Global.currentPlanet);
            int diff = 100 - Global.gas;
            
            if(diff == 0){ Menu.ClearMenuArea(); Console.WriteLine("Gas is already Full"); return;}
            
            for(int i = 0; i <= diff; i++)
            {
                if (Global.money < fuelPrice)
                {
                    Menu.ClearMenuArea();
                    Console.WriteLine($"Could not fill tank. You filled {i} units.");
                    return;
                }
                Global.money -= fuelPrice;
                Global.gas++;
            }
            Menu.ClearMenuArea();
            //center here
            Console.WriteLine("Gas is full");

        }

        public void Travel(int currentPlanet, int travelPlanet) //change current position
        {
            int temp = Global.gas;
            if(currentPlanet == 1 && travelPlanet == 2 || currentPlanet == 2 && travelPlanet == 1)
            {
                Console.WriteLine("Travel");
                Global.gas -= Convert.ToInt32(EarthToPC1 * travelMultiplier);
                if(Global.gas < 0) { Menu.ClearMenuArea(); Global.gas = temp; Console.WriteLine("Not enough Gas to travel..."); }
                Global.age = Convert.ToByte(Global.age + EarthToPC1 / WarpFactor);
                Global.currentPlanet = Convert.ToByte(travelPlanet);
                Menu.ClearMenuArea();
                Console.WriteLine("Gas");
                Console.WriteLine(Global.gas);
                Console.WriteLine("global age");
                Console.WriteLine(Global.age);
                return;
            }
            if (currentPlanet == 1 && travelPlanet == 3 || currentPlanet == 3 && travelPlanet == 1)
            {
                Console.WriteLine("Travel");
                Global.gas -= Convert.ToInt32(EarthToBernard * travelMultiplier);
                if (Global.gas < 0) { Menu.ClearMenuArea(); Global.gas = temp; Console.WriteLine("Not enough Gas to travel..."); }
                byte age = Convert.ToByte(Global.age + EarthToBernard / WarpFactor);
                Global.age = age;
                Global.currentPlanet = Convert.ToByte(travelPlanet);
                Menu.ClearMenuArea();
                Console.WriteLine("Gas");
                Console.WriteLine(Global.gas);
                Console.WriteLine("global age");
                Console.WriteLine(Global.age);
                return;
            }
            if (currentPlanet == 2 && travelPlanet == 3 || currentPlanet == 3 && travelPlanet == 2)
            {
                Console.WriteLine("Travel");
                Global.gas -= Convert.ToInt32(PC1ToBernard * travelMultiplier);
                if (Global.gas < 0) { Menu.ClearMenuArea(); Global.gas = temp; Console.WriteLine("Not enough Gas to travel..."); }
                byte age = Convert.ToByte(Global.age + PC1ToBernard / WarpFactor);
                Global.age = age;
                Global.currentPlanet = Convert.ToByte(travelPlanet);
                Menu.ClearMenuArea();
                Console.WriteLine("Gas");
                Console.WriteLine(Global.gas);
                Console.WriteLine("global age");
                Console.WriteLine(Global.age);
                return;
            }
           
        }

        public double GetWarp()
        {
            if (Global.origin == 1)
            {
                return 2.0;
            }
            if (Global.origin == 2)
            {
                return 1.317;
            }
            if (Global.origin == 3)
            {
                return 1.621;
            }
            else
            {
                return 1.0;
            }
        }

        static double GetTravelMultiplier()
        {
            switch (Global.origin)
            {
                case 1:
                    return 2;
                case 2:
                    return 1.0;
                case 3:
                    return 1.5;

            }
            Menu.ClearMenuArea();
            Console.WriteLine("...");
            return .00;
        }

        public void TravelUI()
        {
            List<string> planets = new List<string>() { "Earth", "Proxima Centauri 1", " Bernard's Star" };

            ConsoleKeyInfo consoleKeyInfo;
            int position = Global.currentPlanet;

            Menu.ClearMenuArea();

            for (int i = 0; i < planets.Count; i++)
            {

                if(i == position - 1)
                {
                    if (i >= 3)
                    {
                        Console.WriteLine($" {planets[i]}");
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine($" {planets[i + 1]}");
                        Console.ResetColor();
                        i++;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine($" {planets[i]}");
                        Console.ResetColor();


                    }
                }
                else
                {
                    Console.WriteLine(planets[i]);
                }

            }
            while ((consoleKeyInfo = Console.ReadKey()).Key != ConsoleKey.Enter)
            {

                Menu.ClearMenuArea();

                if(position == Global.currentPlanet) { position++; }
                if (position == 4) { position = 0; }
                //if(position == 0) { position = 1; }
                if (position == Global.currentPlanet)
                {
                    if (position == 3) { position = 0; }
                    position++;
                }
                    if (consoleKeyInfo.Key == ConsoleKey.DownArrow)
                    {
                        if (position == 1)
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.WriteLine(" Earth");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.WriteLine(" Earth");
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
                            Console.Write(" Bernard's Star");
                            Console.ResetColor();
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine(" Bernard's Star");
                        }
                    position++;
                    }

                //if (consoleKeyInfo.Key == ConsoleKey.UpArrow)
                //{
                //    if(position == 0) { position = 3; }
                //    if (position == 1)
                //    {
                //        Console.BackgroundColor = ConsoleColor.Blue;
                //        Console.WriteLine(" Earth");
                //        Console.ResetColor();
                //    }
                //    else
                //    {
                //        Console.WriteLine(" Earth");
                //    }
                //    if (position == 2)
                //    {
                //        Console.BackgroundColor = ConsoleColor.Blue;
                //        Console.Write(" Proxima Centauri 1");
                //        Console.ResetColor();
                //        Console.WriteLine("");
                //    }
                //    else
                //    {
                //        Console.WriteLine(" Proxima Centauri 1");
                //    }
                //    if (position == 3)
                //    {
                //        Console.BackgroundColor = ConsoleColor.Blue;
                //        Console.Write(" Bernard's Star 1");
                //        Console.ResetColor();
                //        Console.WriteLine("");
                //    }
                //    else
                //    {
                //        Console.WriteLine(" Bernard's Star 1");
                //    }
                //    position--;
                //}

            
            }
            

            Travel(Global.currentPlanet, position);
            return;




        }

        public override string ToString()
        {
            return $"Global.origin {Global.origin} WarpFactor {WarpFactor} Current Gas {Global.age}";
        }
    }
}
