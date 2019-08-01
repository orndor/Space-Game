using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    class App
    {
        
        public void Run()
        {
            Planet earth = new Planet(1);

            //Spaceship userSpaceship = new Spaceship(1, "Rob", 1, 18); //<--This class appears to be broken

            Product product = new Product();

            List<Product> products = new List<Product>();
            List<Product> inventories = new List<Product>();
            product.AddProducts(products);
            Shoping shoping = new Shoping(products);

            // Set the window size (left number is column, right number is row), need to do this only when we first run the program.
            Console.SetWindowSize(180, 50);

            //Need to do this only when we first run the program.
            Console.SetWindowPosition(0, 0);

            // Set the buffer size of console, need to do this only when we first run the program.
            Console.SetBufferSize(181, 50);

            //Example purchases are bleow
            shoping.Buy(inventories, shoping.FindPrice("Oatmeal Pies"));
            shoping.Buy(inventories, shoping.FindPrice("Oatmeal Pies"));
            shoping.Buy(inventories, shoping.FindPrice("Light Bulbs"));
            shoping.Buy(inventories, shoping.FindPrice("Light Bulbs"));
            shoping.Buy(inventories, shoping.FindPrice("Light Bulbs"));
            shoping.Buy(inventories, shoping.FindPrice("Gold"));
            shoping.Buy(inventories, shoping.FindPrice("Gold"));
            shoping.Buy(inventories, shoping.FindPrice("Gold"));
            shoping.Buy(inventories, shoping.FindPrice("Light Bulbs"));
            shoping.Buy(inventories, shoping.FindPrice("Water"));
            shoping.Buy(inventories, shoping.FindPrice("Water"));
            shoping.Buy(inventories, shoping.FindPrice("Liquid Soap"));
            shoping.Buy(inventories, shoping.FindPrice("Gold"));
            shoping.Buy(inventories, shoping.FindPrice("Styrofoam"));
            shoping.Buy(inventories, shoping.FindPrice("Styrofoam"));
            //Example purchases are above

            // Draw the the right and bottom boxes
            PrintSideBottomMenu(inventories);


            //Stop the game to wait on user input
            Console.Write("Press [S] to save game.  Press [Q] to quit.");
            Console.ReadKey(true);
        }
        static void PrintSideBottomMenu(List<Product> inventories)
        {
            int numOfGold = 0;
            int numOfwater = 0;
            int numOfLiquidSoap = 0;
            int numOfStyrofoam = 0;
            int numOfOatmeal = 0;
            int numOfLightBulbs = 0;

            for (int i = 0; i < 41; i++)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(150, i);
                Console.WriteLine(" ");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            //Put current planet, Age, Fuel level, and Money in the right box.
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(152, 0);
            Console.WriteLine("-----===Player Stats===----");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(152, 1);
            Console.WriteLine($"           Age: 18");
            Console.SetCursorPosition(152, 3);
            Console.WriteLine($"          Fuel: 100%");
            Console.SetCursorPosition(152, 5);
            Console.WriteLine($"        Wallet: {Global.money} Cubits");
            Console.SetCursorPosition(152, 7);
            Console.WriteLine($"Current Planet: Earth");



            //Put current inventory in the bottom box
            for (int i = 0; i < inventories.Count; i++)
            {
                if (inventories[i].ProductName == "Gold")
                    numOfGold += 1;
            }
            for (int i = 0; i < inventories.Count; i++)
            {
                if (inventories[i].ProductName == "Water")
                    numOfwater += 1;
            }
            for (int i = 0; i < inventories.Count; i++)
            {
                if (inventories[i].ProductName == "Liquid Soap")
                    numOfLiquidSoap += 1;
            }
            for (int i = 0; i < inventories.Count; i++)
            {
                if (inventories[i].ProductName == "Styrofoam")
                    numOfStyrofoam += 1;
            }
            for (int i = 0; i < inventories.Count; i++)
            {
                if (inventories[i].ProductName == "Oatmeal Pies")
                    numOfOatmeal += 1;
            }
            for (int i = 0; i < inventories.Count; i++)
            {
                if (inventories[i].ProductName == "Light Bulbs")
                    numOfLightBulbs += 1;
            }

            for (int i = 0; i < 180; i++)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(i, 40);
                Console.WriteLine(" ");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(0, 41);
            Console.WriteLine("--------=====Inventory=====--------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 42);
            Console.WriteLine($"       Gold: {numOfGold}");
            Console.SetCursorPosition(0, 43);
            Console.WriteLine($"      Water: {numOfwater}");
            Console.SetCursorPosition(0, 44);
            Console.WriteLine($"Liquid Soap: {numOfLiquidSoap}");
            Console.SetCursorPosition(20, 42);
            Console.WriteLine($"   Styrofoam: {numOfStyrofoam}");
            Console.SetCursorPosition(20, 43);
            Console.WriteLine($"Oatmeal Pies: {numOfOatmeal}");
            Console.SetCursorPosition(20, 44);
            Console.WriteLine($" Light Bulbs: {numOfLightBulbs}");
            Console.WriteLine($" ");
            Console.WriteLine($" ");
            Console.WriteLine($" ");
        }
    }
}
