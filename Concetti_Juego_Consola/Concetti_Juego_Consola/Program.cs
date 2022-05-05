using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Concetti_Juego_Consola
{
    class player
    {

        public int posY = 0;
        public int posX = 0;
    }

    class enemy
    {
        public int posY = 10;
        public int posX = 10;
    }
    class Program
    {
        static player play = new player();
        static enemy en = new enemy();

        static bool running = true;

        static void Main(string[] args)
        {
            while (running)
            {
                input();
                render();
            }
        }

        static void input()
        {
            ConsoleKeyInfo cki = Console.ReadKey();
            if (cki.Key == ConsoleKey.LeftArrow)
            {
                if (play.posX != 0)
                {
                    play.posX--;
                }
            }

            if (cki.Key == ConsoleKey.RightArrow)
            {
                
                    play.posX++;
                
               
            }

            if (cki.Key == ConsoleKey.UpArrow)
            {
                if (play.posY > 0)
                {
                    play.posY--;
                }
            }

            if (cki.Key == ConsoleKey.DownArrow)
            {
                play.posY++;
            }

            if (cki.Key == ConsoleKey.Escape)
            {
                running = false;
            }
        }

        static void render()
        {
            
               
                Console.Clear();
                Console.SetCursorPosition(play.posX, play.posY);
                Console.Write("X");

            Console.SetCursorPosition(en.posX, en.posY);
            Console.Write("Y");
        }
    }
}
