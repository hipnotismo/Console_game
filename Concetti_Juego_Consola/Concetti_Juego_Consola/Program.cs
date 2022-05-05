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

        public int posY = 2;
        public int posX = 2;
    }

    class enemy
    {
        public int posY = 10;
        public int posX = 10;
        public int random = 0;
    }
    class Program
    {
        static player play = new player();
        static enemy en = new enemy();
        static Random rnd = new Random();
        static bool running = true;

        static void Main(string[] args)
        {
            while (running)
            {
                input();
                update();
                render();
            }
        }

        static void input()
        {
            if (Console.KeyAvailable)
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
                    if (play.posY > 1)
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
        }

        static void update()
        {
            en.random = rnd.Next(1, 5);
            switch (en.random)
            {
                case 1:
                    en.posX--;
                    break;
                case 2:
                    en.posX++;
                    break;
                case 3:
                    en.posY--;
                    break;
                case 4:
                    en.posY++;
                    break;
                default:
                    break;
            }

        }
        static void render()
        {


             Console.Clear();
            Console.SetCursorPosition(play.posX, play.posY);
            Console.Write("X");

            Console.SetCursorPosition(en.posX, en.posY);
            Console.Write("Y");

            Thread.Sleep(70);
        }
    }
}
