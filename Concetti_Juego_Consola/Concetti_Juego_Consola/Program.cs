﻿using System;
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
        static powerUp power = new powerUp();
        static Random rnd = new Random();
        static Random ranPos = new Random();
        static bool running = true;
        static int points = 0;
        static int lives = 5;
        static int saveRan = 0;

        //pantall es 29 en Y, 118 en X
        
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
            enemyCollision();
            powerCollision();
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
            if (power.active == false)
            {
                Console.SetCursorPosition(40, 0);
                Console.Write("Atacar");
            }
            play.playerDraw();

            en.enemyDraw();

            power.powerDraw();

            Thread.Sleep(100);
        }
        static void enemyCollision() 
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

                }
            }
        }
        static void powerCollision()
        {
            if (play.posX == power.posX && play.posY == power.posY)              
            {
                play.destroy = true;
                power.active = false;
            }
        }
    }
}
