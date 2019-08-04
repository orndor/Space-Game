using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Space_Game
{
    class OpenAndEndCredits
    {
        static public void OpeningCredits()
        {
            string line;
            var path = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\..\\intro.txt");
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            do
            {
                line = null;
                for (int i = 0; i < 5; i++)
                {
                    line = file.ReadLine();
                    Console.SetCursorPosition(20, 10+i);
                    Console.WriteLine(line);
                }
                Console.SetCursorPosition(20, 20);
                Console.WriteLine("Press the Space Bar to Continue...");
                do
                {
                    continue;
                } while ((Console.ReadKey(true).Key != ConsoleKey.Spacebar));
                Menu.ClearMenuArea();
            } while (line != null);
            file.Close();

        }

        static public void WinEndingCredits()
        {

        }

        static public void LoseEndingCredits()
        {

        }
    }
}
