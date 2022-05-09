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
        static int points = 0;
        static int lives = 5;

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
                ConsoleKeyInfo cki = Console.ReadKey();

                play.playerMovement();

                if (cki.Key == ConsoleKey.Escape)
                {
                    running = false;
                }
            }
        }

        static void update()
        {
            input();
            render();
            en.random = rnd.Next(1, 5);
            en.enemyMovement(en.random,ref en.posX,ref en.posY);         
        }
      
        static void render()
        {
            Console.Clear();

            Console.SetCursorPosition(0, 0);
            Console.Write("Points: ");

            Console.SetCursorPosition(7, 0);
            Console.Write(points);

            Console.SetCursorPosition(30, 0);
            Console.Write("Lives: ");

            Console.SetCursorPosition(36, 0);
            Console.Write(lives);

            play.playerDraw();

            en.enemyDraw();

            Thread.Sleep(100);
        }
    }
}
