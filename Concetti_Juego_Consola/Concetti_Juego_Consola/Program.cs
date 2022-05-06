using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Concetti_Juego_Consola
{
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
                update();
              
            }
        }

        static void input()
        {
            if (Console.KeyAvailable)
            {
                playerMovement();
            }
        }

        static void update()
        {
            input();
            render();
            enemyMovement();         
        }

        static void enemyMovement()
        {
            en.random = rnd.Next(1, 5);
            switch (en.random)
            {
                case 1:
                    if (en.posX > 1)
                    {
                        en.posX--;
                    }
                    else
                    {
                        en.posX++;
                    }
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

        static void playerMovement()
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

        static void render()
        {
            Console.Clear();

            Console.SetCursorPosition(0, 0);
            Console.Write("Puntos");

            Console.SetCursorPosition(play.posX, play.posY);
            Console.Write("X");

            Console.SetCursorPosition(en.posX, en.posY);
            Console.Write("Y");

            Thread.Sleep(100);
        }
    }
}
