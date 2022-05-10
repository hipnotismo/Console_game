using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Concetti_Juego_Consola
{
    class GameManager
    {
        static Player play = new Player();
        static Enemy en = new Enemy();
        static PowerUp power = new PowerUp();
        static Random rnd = new Random();
        static Random ranPos = new Random();

        static bool running = true;
        static int points = 0;
        static int lives = 5;
        static int saveRan = 0;

        public void RunGame()
        {
            while (running)
            {
                Update();
            }
        }

        static void Input()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo cki = Console.ReadKey();

                play.PlayerMovement();

                if (cki.Key == ConsoleKey.Escape)
                {
                    running = false;
                }
            }
        }

        static void Update()
        {
            Input();
            Render();
            en.random = rnd.Next(1, 5);
            en.EnemyMovement(en.random, ref en.posX, ref en.posY);
            EnemyCollision();
            PowerCollision();
        }

        static void Render()
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
            if (power.active == false)
            {
                Console.SetCursorPosition(40, 0);
                Console.Write("Atacar");
            }
            play.PlayerDraw();

            en.EnemyDraw();

            power.PowerDraw();

            Thread.Sleep(100);
        }
        static void EnemyCollision()
        {
            if (play.posX == en.posX && play.posY == en.posY)
            {
                if (play.destroy == false)
                {
                    saveRan = ranPos.Next(1, 5);
                    switch (saveRan)
                    {
                        case 1:
                            play.posX = 5;
                            play.posY = 5;
                            break;
                        case 2:
                            play.posX = 5;
                            play.posY = 20;
                            break;
                        case 3:
                            play.posX = 30;
                            play.posY = 15;
                            break;
                        case 4:
                            play.posX = 15;
                            play.posY = 30;
                            break;
                        default:
                            break;
                    }

                    lives--;

                    if (lives == 0)
                    {
                        running = false;
                    }
                }
                else
                {
                    points++;
                    play.destroy = false;
                    power.active = true;
                    en.posX = ranPos.Next(1, 20);
                    en.posY = ranPos.Next(1, 40);
                    power.posX = ranPos.Next(1, 20);
                    power.posY = ranPos.Next(1, 40);
                }
            }
        }
        static void PowerCollision()
        {
            if (play.posX == power.posX && play.posY == power.posY)
            {
                play.destroy = true;
                power.active = false;
            }
        }
    }
}

