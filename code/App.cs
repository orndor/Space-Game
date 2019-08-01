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
            Console.SetWindowSize(150, 40);

            //Need to do this only when we first run the program.
            Console.SetWindowPosition(0, 0);

            // Set the buffer size of console, need to do this only when we first run the program.
            Console.SetBufferSize(150, 40);

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

            for (int i = 0; i < 31; i++)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(120, i);
                Console.WriteLine(" ");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            //Put current planet, Age, Fuel level, and Money in the right box.
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(122, 0);
            Console.WriteLine("-----===Player Stats===----");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(122, 1);
            Console.WriteLine($"           Age: 18");
            Console.SetCursorPosition(122, 3);
            Console.WriteLine($"          Fuel: 100%");
            Console.SetCursorPosition(122, 5);
            Console.WriteLine($"        Wallet: {Global.money} Cubits");
            Console.SetCursorPosition(122, 7);
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

            for (int i = 0; i < 150; i++)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(i, 30);
                Console.WriteLine(" ");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(0, 31);
            Console.WriteLine("--------=====Inventory=====--------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 32);
            Console.WriteLine($"       Gold: {numOfGold}");
            Console.SetCursorPosition(0, 33);
            Console.WriteLine($"      Water: {numOfwater}");
            Console.SetCursorPosition(0, 34);
            Console.WriteLine($"Liquid Soap: {numOfLiquidSoap}");
            Console.SetCursorPosition(20, 32);
            Console.WriteLine($"   Styrofoam: {numOfStyrofoam}");
            Console.SetCursorPosition(20, 33);
            Console.WriteLine($"Oatmeal Pies: {numOfOatmeal}");
            Console.SetCursorPosition(20, 34);
            Console.WriteLine($" Light Bulbs: {numOfLightBulbs}");
            Console.WriteLine($" ");
            Console.WriteLine($" ");
            Console.WriteLine($" ");
        }
    }
}
