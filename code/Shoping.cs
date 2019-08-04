using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    class Shoping
    {
        List<Product> market = new List<Product>();
        List<Product> menuList = new List<Product>();
        public Shoping(List<Product> products)
        {
            market = products;
        }
        public Product FindPrice(string productName)
        {
            Product item=new Product() { ProductName = "Gold", Price = 100, Planet = 1 };
            foreach (Product i in market)
            {
                if ((i.ProductName == productName) && (i.Planet == Global.currentPlanet))
                {
                    item=i;
                    break;
                }
            }
            return item;
        }

        public bool Buy(List<Product> inventory, Product item)
        {
            if (item.Price <= Global.money)
            {
                Global.money -= item.Price;
                inventory.Add(item);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Sell(List<Product> inventory, Product item)
        {
            inventory.Remove(item);
            Global.money += item.Price;
        }

        public bool PrintSellList(List<Product> inventory)
        {
            if (inventory.Count <= 0)
            {
                //Console.WriteLine("Inventory is empty!");
                return false;
            }
            else
            {
                menuList.Clear();
                Menu.ClearMenuArea();
                foreach (var item in inventory)
                { 
                    Console.WriteLine($"{item.ProductName} {item.Price}");
                    menuList.Add(item);
                }
                Sell(inventory, Navigation(inventory));
                return true;
            }
            
        }

        public bool PrintBuyList(List<Product> inventory)
        {
            menuList.Clear();
            Menu.ClearMenuArea();
            foreach (var item in market)
            {
                    if (item.Planet==Global.currentPlanet)
                    {
                        Console.WriteLine($"{item.ProductName} {item.Price}");
                        menuList.Add(item);
                    }                   
            }
                
            return Buy(inventory, Navigation(inventory));
        }

        Product Navigation(List<Product> inventory)
        {
            ConsoleKeyInfo consoleKeyInfo;
            //int[] menuList = new int[5];
           
            int index = 0;
            // When the arrow down key is pressed first time
                Console.SetCursorPosition(0, index);
                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.Blue;
                //Console.Write("\r" + new string(' ', Convert.ToString(menuList[index]).Length) + "\r"); // Clear current line
                Console.Write($"{menuList[index].ProductName} {menuList[index].Price}".PadRight(119, ' ')); // Rewrite it with matching index array item
            

            //for (int x = 0; x < 5; x++) menuList[x] = x;
            //foreach (var i in menuList) Console.WriteLine(i);

           // Console.SetCursorPosition(0, 0);

            while ((consoleKeyInfo = Console.ReadKey()).Key != ConsoleKey.Enter)
            {
                switch(consoleKeyInfo.Key)//if (consoleKeyInfo.Key == ConsoleKey.DownArrow)
                {
                    case ConsoleKey.DownArrow:
                    index++;
                    if (index >= 0 && index < menuList.Count)
                    {
                        Console.SetCursorPosition(0, index - 1);
                        Console.ResetColor();
                        //Console.Write("\r" + new string(' ', Convert.ToString(menuList[index - 1]).Length) + "\r"); // Clear previous line
                        Console.Write($"{menuList[index - 1].ProductName} {menuList[index - 1].Price}".PadRight(119, ' ')); // Rewrite it

                        Console.SetCursorPosition(0, index);
                        Console.ResetColor();
                        Console.BackgroundColor = ConsoleColor.Blue;
                        //Console.Write("\r" + new string(' ', Convert.ToString(menuList[index]).Length) + "\r"); // Clear current line
                        Console.Write($"{menuList[index].ProductName} {menuList[index].Price}".PadRight(119, ' ')); // Rewrite it
                    }
                    // When the index is same/greater than menuList length, keep it with the same value
                    // So the index doesn't increment
                    else if(index >= menuList.Count)
                    {
                        Console.SetCursorPosition(0, index-1 );
                        Console.ResetColor();
                        //Console.Write("\r" + new string(' ', Convert.ToString(menuList[index-1]).Length) + "\r"); // Clear previous line
                        Console.Write($"{menuList[index - 1].ProductName} {menuList[index - 1].Price}".PadRight(119, ' '));
                        index = 0;// index = menuList.Count - 1;
                        Console.SetCursorPosition(0, index);
                        Console.ResetColor();
                        Console.BackgroundColor = ConsoleColor.Blue;
                        //Console.Write("\r" + new string(' ', Convert.ToString(menuList[index]).Length) + "\r"); // Clear current line
                        Console.Write($"{menuList[index].ProductName} {menuList[index].Price}".PadRight(119, ' '));
                    }
                        break;
                    case ConsoleKey.UpArrow:
                        index--;//if (index > 0) index--;
                        if (index >= 0 && index < menuList.Count)
                        {
                            // Same as above
                            Console.SetCursorPosition(0, index + 1);
                            Console.ResetColor();
                            //Console.Write("\r" + new string(' ', Convert.ToString(menuList[index + 1]).Length) + "\r");
                            Console.Write($"{menuList[index + 1].ProductName} {menuList[index + 1].Price}".PadRight(119, ' '));

                            Console.SetCursorPosition(0, index);
                            Console.ResetColor();
                            Console.BackgroundColor = ConsoleColor.Blue;
                            //Console.Write("\r" + new string(' ', Convert.ToString(menuList[index]).Length) + "\r");
                            Console.Write($"{menuList[index].ProductName} {menuList[index].Price}".PadRight(119, ' '));
                        }
                        else if (index < 0)
                        {
                            Console.SetCursorPosition(0, index+1 );
                            Console.ResetColor();
                            //Console.Write("\r" + new string(' ', Convert.ToString(menuList[index-1]).Length) + "\r"); // Clear previous line
                            Console.Write($"{menuList[index+1].ProductName} {menuList[index+1].Price}".PadRight(119, ' '));
                            index = menuList.Count-1;// index = menuList.Count - 1;
                            Console.SetCursorPosition(0, index);
                            Console.ResetColor();
                            Console.BackgroundColor = ConsoleColor.Blue;
                            //Console.Write("\r" + new string(' ', Convert.ToString(menuList[index]).Length) + "\r"); // Clear current line
                            Console.Write($"{menuList[index].ProductName} {menuList[index].Price}".PadRight(119, ' '));
                        }
                        break;
                    default:
                        Console.Write("\b \b");
                        break;

                }
                //else if (consoleKeyInfo.Key == ConsoleKey.UpArrow) // Up arrow is intended to work only, when the index is greater than 0 (so the second or greater option is selected)
               
            }
            //Buy(inventory, menuList[index]);
            Console.ResetColor();

            return menuList[index];
        }

    }
}
