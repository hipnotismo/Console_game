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
                play.playerMovement();
                //if (cki.Key == ConsoleKey.Escape)
                //{
                //    running = false;
                //}
            }
        }

        static void update()
        {
            input();
            render();
            en.random = rnd.Next(1, 5);
            en.enemyMovement(en.random,ref en.posX,ref en.posY);         
        }
      
        //static void playerMovement()
        //{
        //    ConsoleKeyInfo cki = Console.ReadKey();
        //    if (cki.Key == ConsoleKey.LeftArrow)
        //    {
        //        if (play.posX != 0)
        //        {
        //            play.posX--;
        //        }
        //    }

        //    if (cki.Key == ConsoleKey.RightArrow)
        //    {
        //        play.posX++;
        //    }

        //    if (cki.Key == ConsoleKey.UpArrow)
        //    {
        //        if (play.posY > 1)
        //        {
        //            play.posY--;
        //        }
        //    }

        //    if (cki.Key == ConsoleKey.DownArrow)
        //    {
        //        play.posY++;
        //    }

        //    if (cki.Key == ConsoleKey.Escape)
        //    {
        //        running = false;
        //    }
        //}

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

            Console.SetCursorPosition(play.posX, play.posY);
            Console.Write("X");

            Console.SetCursorPosition(en.posX, en.posY);
            Console.Write("Y");

            Thread.Sleep(100);
        }
    }
}
