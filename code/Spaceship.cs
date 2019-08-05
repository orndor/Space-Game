using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Space_Game
{
    class Spaceship// : ISpaceship
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
            
            for(int i = 0; i < diff; i++)
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

        }

        public void Travel() //change current position
        {

            int travelPlanet = Navigation().PlanetNum;
            int temp = Global.gas;
            if(Global.currentPlanet == 1 && travelPlanet == 2 || Global.currentPlanet == 2 && travelPlanet == 1)
            {
                Console.WriteLine("Travel");
                Global.gas -= Convert.ToInt32(EarthToPC1 * travelMultiplier);
                if(Global.gas < 0) { Menu.ClearMenuArea(); Global.gas = temp; Console.WriteLine("Not enough Gas to travel..."); }
                Global.age = Convert.ToByte(Global.age + EarthToPC1 / WarpFactor);
                Global.currentPlanet = Convert.ToByte(travelPlanet);
            }
            if (Global.currentPlanet == 1 && travelPlanet == 3 || Global.currentPlanet == 3 && travelPlanet == 1)
            {
                Console.WriteLine("Travel");
                Global.gas -= Convert.ToInt32(EarthToBernard * travelMultiplier);
                if (Global.gas < 0) { Menu.ClearMenuArea(); Global.gas = temp; Console.WriteLine("Not enough Gas to travel..."); }
                byte age = Convert.ToByte(Global.age + EarthToBernard / WarpFactor);
                Global.age = age;
                Global.currentPlanet = Convert.ToByte(travelPlanet);
            }
            if (Global.currentPlanet == 2 && travelPlanet == 3 || Global.currentPlanet == 3 && travelPlanet == 2)
            {
                Console.WriteLine("Travel");
                Global.gas -= Convert.ToInt32(PC1ToBernard * travelMultiplier);
                if (Global.gas < 0) { Menu.ClearMenuArea(); Global.gas = temp; Console.WriteLine("Not enough Gas to travel..."); }
                byte age = Convert.ToByte(Global.age + PC1ToBernard / WarpFactor);
                Global.age = age;
                Global.currentPlanet = Convert.ToByte(travelPlanet);
            }

            if(travelPlanet == 1)
            {
                Cutscenes.EarthCutScene();
            }
            else if(travelPlanet == 2)
            {
                Cutscenes.ProximaCutscene();
            }
            else if(travelPlanet == 3)
            {
                Cutscenes.BarnardCutscene();
            }

            return;
           
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
                Menu.ClearMenuArea();
                Console.WriteLine("...");
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
            return 1.0;
        }

        //public void TravelUI()
        //{
        //    List<string> planets = new List<string>() { "Earth", "Proxima Centauri 1", " Bernard's Star" };

        //    ConsoleKeyInfo consoleKeyInfo;
        //    int position = -1;

        //    Menu.ClearMenuArea();


        //    while ((consoleKeyInfo = Console.ReadKey()).Key != ConsoleKey.Enter)
        //    {

               
                


        //        if (consoleKeyInfo.Key == ConsoleKey.DownArrow)
        //        {
        //            if (position + 1 == planets.Count) { position = -1; }

        //            position++;

        //            if (position + 1 != planets.Count)
        //            {
        //                for (int i = 0; i < planets.Count; i++)
        //                {
                            
        //                    if (position + 1 == Global.currentPlanet)
        //                    {
        //                        Console.WriteLine($"Current Planet: {planets[position]}");
        //                    }
        //                    else
        //                    {
        //                        if (i == position)
        //                        {
        //                            Console.BackgroundColor = ConsoleColor.Blue;
        //                            Console.WriteLine($"          {planets[i]}");
        //                            Console.ResetColor();
        //                        }
        //                        else
        //                        {
        //                            Console.WriteLine($"          {planets[i]}");
        //                        }
        //                    }
        //                    i++;
        //                }
        //            }
                    
        //        }

        //    }
        //    Travel(Global.currentPlanet, position);
        //    return;

        //}







        /*
                        if (Global.currentPlanet == 1)
                            {
                                switch (position)
                                {
                                    case 1:
                                        break;
                                    case 2:
                                        break;
                                }
                            }
                            if(Global.currentPlanet == 2)
                            {
                                switch (position)
                                {
                                    case 1:
                                        break;
                                    case 2:
                                        break;

                                }

                            }
                            if(Global.currentPlanet == 3)
                            {
                                switch (position)
                                {
                                    case 1:
                                        break;
                                    case2:
                                        break;

                                }

                            }
                            position++;
                            }
                            */


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



        public override string ToString()
        {
            return $"Global.origin {Global.origin} WarpFactor {WarpFactor} Current Gas {Global.age}";
        }



        //////////////////////////////////////////////////////////////////////////////////////////
        ///SHOD//////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////


        Planet Navigation()
        {
            List<Planet> planet = new List<Planet>()
                                            {
                                                new Planet() { PlanetName = "Earth", PlanetNum= 1 },
                                                new Planet() { PlanetName = "Proxima Centauri 1", PlanetNum= 2 },
                                                new Planet() { PlanetName = "Bernard's Star 1", PlanetNum= 3 }
                                            };

            var planetToRemove = planet.Single(r => r.PlanetNum == Global.currentPlanet);
            planet.Remove(planetToRemove);


            PrintPlanet(planet);
            ConsoleKeyInfo consoleKeyInfo;
         

            int index = 0;
          
            Console.SetCursorPosition(0, index);
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Blue;     
            Console.Write($"{planet[index].PlanetName}".PadRight(119, ' '));



            while ((consoleKeyInfo = Console.ReadKey()).Key != ConsoleKey.Enter)
            {
                switch (consoleKeyInfo.Key)
                {
                    case ConsoleKey.DownArrow:
                        index++;
                        if (index >= 0 && index < planet.Count)
                        {
                            Console.SetCursorPosition(0, index - 1);
                            Console.ResetColor();
                            Console.Write($"{planet[index - 1].PlanetName}".PadRight(119, ' ')); 

                            Console.SetCursorPosition(0, index);
                            Console.ResetColor();
                            Console.BackgroundColor = ConsoleColor.Blue;
                      
                            Console.Write($"{planet[index].PlanetName}".PadRight(119, ' ')); 
                        }
                       
                        else if (index >= planet.Count)
                        {
                            Console.SetCursorPosition(0, index - 1);
                            Console.ResetColor();
                            Console.Write($"{planet[index - 1].PlanetName}".PadRight(119, ' '));
                            index = 0;
                            Console.SetCursorPosition(0, index);
                            Console.ResetColor();
                            Console.BackgroundColor = ConsoleColor.Blue;
                           
                            Console.Write($"{planet[index].PlanetName}".PadRight(119, ' '));
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        index--;
                        if (index >= 0 && index < planet.Count)
                        {
                  
                            Console.SetCursorPosition(0, index + 1);
                            Console.ResetColor();
                      
                            Console.Write($"{planet[index + 1].PlanetName}".PadRight(119, ' '));

                            Console.SetCursorPosition(0, index);
                            Console.ResetColor();
                            Console.BackgroundColor = ConsoleColor.Blue;
                     
                            Console.Write($"{planet[index].PlanetName}".PadRight(119, ' '));
                        }
                        else if (index < 0)
                        {
                            Console.SetCursorPosition(0, index + 1);
                            Console.ResetColor();
                          
                            Console.Write($"{planet[index + 1].PlanetName}".PadRight(119, ' '));
                            index = planet.Count - 1;
                            Console.SetCursorPosition(0, index);
                            Console.ResetColor();
                            Console.BackgroundColor = ConsoleColor.Blue;
                           
                            Console.Write($"{planet[index].PlanetName}".PadRight(119, ' '));
                        }
                        break;
                    default:
                        Console.Write("\b \b");
                        break;

                }
             
            }
   
            Console.ResetColor();

            return planet[index];
        }


        public void PrintPlanet(List<Planet> p)
        {
            if (p.Count <= 0)
            {
                //Console.WriteLine("Inventory is empty!");
                //return false;
            }
            else
            {
                
                Menu.ClearMenuArea();
                foreach (var item in p)
                {
                    Console.WriteLine($"{item.PlanetName}");
                    //menuList.Add(item);
                }
                //Sell(inventory, Navigation(inventory));
                //return true;
            }

        }


    }
}
