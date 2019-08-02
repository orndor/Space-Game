﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Space_Game
{
    class Menu
    {
        //List<string> menu = new List<string>() {"Travel", "Buy", "Sell", "Refuel", "Exit" };
        public void KeyCatch(List<Product> inventories, List<Product> products)
        {
            Spaceship userSpaceship = new Spaceship(1, Global.name);

            Welcome(inventories, userSpaceship);

            ClearMenuArea();

            OpenAndEndCredits.OpeningCredits();

            ClearMenuArea();

            PrintMenu();
            //Spaceship userSpaceship = new Spaceship(1, Global.name);
            Planet planet = new Planet();

            Console.SetCursorPosition(20, 11);
            PrintAnimation($"{Global.name}, please select an action by pressing a key from the bellow menu");
            ConsoleKeyInfo consoleKeyInfo;

            PrintMenu();

            
            Shoping shoping = new Shoping(products);
            Spaceship spaceship = new Spaceship(Global.origin, Global.name, Global.age);
            
            while ((consoleKeyInfo = Console.ReadKey()).Key != ConsoleKey.F12) //if pressed F12 close app
            {
                switch (consoleKeyInfo.Key)
                {
                    case ConsoleKey.F1://travel
                        spaceship.TravelUI();
                        break;
                    case ConsoleKey.F2://Buy
                        if (shoping.PrintBuyList(inventories))
                        {
                            ClearMenuArea();
                            Console.SetCursorPosition(10, 10);
                            PrintAnimation($"The item was added to your inventory");
                        }
                        else
                        {
                            ClearMenuArea();
                            Console.SetCursorPosition(10, 10);
                            PrintAnimation($"Soryy {Global.name}, but you don't have enough money to buy the item");                           
                        }
                        
                        //Console.ResetColor();
                        PrintMenu();
                        
                        App.PrintSideBottomMenu(inventories, userSpaceship);
                        
                        Console.SetCursorPosition(10, 12);
                        PrintAnimation($"{Global.name}, please select an action by pressing a key from the bellow menu");
                        break;
                    case ConsoleKey.F3://Sell
                        shoping.PrintSellList(inventories);
                        Console.Clear();
                        Console.ResetColor();
                        PrintMenu();
                        
                        App.PrintSideBottomMenu(inventories, userSpaceship);
                        Console.SetCursorPosition(0, 0);
                        break;
                    case ConsoleKey.F4://Refuel
                        spaceship.ReFuel(planet.GetFuel(Global.currentPlanet));
                        break;

                    default:

                        break;
                }
            }
           
        }

        public void PrintMenu() //This method print -ItemsPerPage- and Menu
        {
            Console.SetCursorPosition(0, 26);
            Console.WriteLine(new string('=', 120));
            Console.Write(" F1. Travel");
            Console.Write(" || F2. Buy");
            Console.Write(" || F3. Sell");
            Console.Write(" || F4. Refuel");
            Console.WriteLine(" || F12. Exit");
            Console.WriteLine(new string('=', 120));
        }

        void Welcome(List<Product> inventories, Spaceship userSpaceship)
        {
            Console.SetCursorPosition(50, 2);
            PrintAnimation("Welcome to Space Game!");
            
            Console.SetCursorPosition(50, 4);
            PrintAnimation("What is your name?");      
            Global.name=Console.ReadLine();
            PrintPlanetList(inventories, userSpaceship);
        }

        void PrintAnimation(string txt)
        {
            for (int i = 0; i < txt.Length; i++)
            {
                Console.Write(txt[i]);
                Thread.Sleep(1);
            }
        }


        public static void ClearMenuArea()
        {
            Console.ResetColor();
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine(new string(' ', 120));
            }
            Console.SetCursorPosition(0, 0);
        }

        void PrintPlanetList(List<Product> inventories, Spaceship userSpaceship)
        {
            //bool exit = false;
                           
                byte origin = 0;
                Console.SetCursorPosition(50, 6);
                PrintAnimation($"{Global.name} select your origin");
                Console.SetCursorPosition(50, 7);
                PrintAnimation("1. Earth");
                Console.SetCursorPosition(50, 8);
                PrintAnimation("2. Proxima Centauri 1");
                Console.SetCursorPosition(50, 9);
                PrintAnimation("3. Bernard's Star 1");
                Console.SetCursorPosition(50, 10);
                Console.Write("Inputing 1, 2 or 3 >> ");
            do
            {
                if (byte.TryParse(Console.ReadLine(), out origin))
                    if (origin >= 1 && origin <= 3)
                    {
                        Global.origin = origin;
                        break;
                    }
                Console.SetCursorPosition(0, 10);
                Console.Write(new string(' ', 120));
                Console.SetCursorPosition(25, 10);
                Console.Write("Error: the number is not valid, inputing 1, 2 or 3 >> ");            
            } while (true);
            Global.currentPlanet = Global.origin;
            App.PrintSideBottomMenu(inventories, userSpaceship);

        }
    }
}
