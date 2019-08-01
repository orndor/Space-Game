using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    class Menu
    {
        //List<string> menu = new List<string>() {"Travel", "Buy", "Sell", "Refuel", "Exit" };
        public void KeyCatch(List<Product> inventories, List<Product> products)
        {

            PrintMenu();
            ConsoleKeyInfo consoleKeyInfo;
            Console.SetCursorPosition(0, 0);
            Shoping shoping = new Shoping(products);
            //Spaceship spaceship = new Spaceship();

            while ((consoleKeyInfo = Console.ReadKey()).Key != ConsoleKey.F12) //if pressed F12 close app
            {
                switch (consoleKeyInfo.Key)
                {
                    case ConsoleKey.F1://travel
                        
                        break;
                    case ConsoleKey.F2://Buy
                        shoping.PrintBuyList(inventories);
                        Console.Clear();
                        Console.ResetColor();
                        PrintMenu();
                        Console.SetCursorPosition(0, 0);
                        break;
                    case ConsoleKey.F3://Sell
                        shoping.PrintSellList(inventories);
                        Console.Clear();
                        Console.ResetColor();
                        PrintMenu();
                        Console.SetCursorPosition(0, 0);
                        break;
                    case ConsoleKey.F4://Refuel
                        
                        break;

                    default:

                        break;
                }
            }
           
        }

        public void PrintMenu() //This method print -ItemsPerPage- and Menu
        {
            Console.SetCursorPosition(0, 20);
            Console.WriteLine(new string('=', 120));
            Console.Write(" F1. Travel");
            Console.Write(" || F2. Buy");
            Console.Write(" || F3. Sell");
            Console.Write(" || F4. Refuel");
            Console.WriteLine(" || F12. Exit");
            Console.WriteLine(new string('=', 120));
        }
    }
}
