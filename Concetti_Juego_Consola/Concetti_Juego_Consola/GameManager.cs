using System;
using System.Threading;

namespace Concetti_Juego_Consola
{
    class GameManager
    {
        static Player play = null;
        static Player play2 = null;
        static Enemy en = null;
        static Enemy en2 = null;
        static Enemy en3 = null;

        static PowerUp power = null;
        static Random rnd = null;
        static Random ranPos = null;

        static bool running = true;
        static int points = 0;
        static int lives = 5;

        static int points2 = 0;
        static int lives2 = 5;

        static int saveRan = 0;

        public void RunGame()
        {
            Init();
            while (running)
            {
                Update();
            }
        }

        static void Init()
        {
            Console.CursorVisible = false;
            play = new Player(2,2, "♂");
            play2 = new Player(10,10, "☺");
            en = new Enemy(15,15,"X",1);
            en2 = new Enemy(10, 10, "X", 2);
            en3 = new Enemy(25, 25, "X", 3);

            power = new PowerUp(28,28, true, "@");
            rnd = new Random();
            ranPos = new Random();
        }

        static void Input()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo cki = Console.ReadKey();
                int ref1 = 0;
                int ref2 = 0;

                if (cki.Key == ConsoleKey.LeftArrow) ref1 = 1;
                if (cki.Key == ConsoleKey.RightArrow) ref1 = 2;
                if (cki.Key == ConsoleKey.UpArrow) ref1 = 3;
                if (cki.Key == ConsoleKey.DownArrow) ref1 = 4;


                if (cki.Key == ConsoleKey.A) ref2 = 1;
                if (cki.Key == ConsoleKey.D) ref2 = 2;
                if (cki.Key == ConsoleKey.W) ref2 = 3;
                if (cki.Key == ConsoleKey.S) ref2 = 4;

                play.PlayerMovement(ref1);
                play2.PlayerMovement(ref2);
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
            en._ran = rnd.Next(1, 5);
            en.EnemyMovement(en._ran);
            en._ran = rnd.Next(1, 3);
            en2.EnemyMovement(en._ran);
            en._ran = rnd.Next(1, 5);
            en3.EnemyMovement(en._ran);
            EnemyCollision();
            PowerCollision();
        }

        static void Render()
        {
            Console.Clear();

            Console.SetCursorPosition(0, 0);
            Console.Write("Points ♂: " + points);

            Console.SetCursorPosition(10, 0);
            Console.Write("Lives ♂: " + lives);

            Console.SetCursorPosition(25, 0);
            Console.Write("Points ☺: " + points2);

            Console.SetCursorPosition(35, 0);
            Console.Write("Lives ☺: " + lives2);

            if (power._active == false)
            {
                Console.SetCursorPosition(40, 0);
                Console.Write("Atacar ♂");
            }

            play.PlayerDraw();
            play2.PlayerDraw();

            en.EnemyDraw();
            en2.EnemyDraw();
            en3.EnemyDraw();
            power.PowerDraw();

            Thread.Sleep(100);
        }

        static void EnemyCollision()
        {
            if (play._posX == en._posX && play._posY == en._posY)
            {
                if (play.destroy == false)
                {
                   
                    saveRan = ranPos.Next(1, 30);
                    play._posX = saveRan;
                   saveRan = ranPos.Next(1, 30);
                    play._posY = saveRan;
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
                    power._active = true;
                    en._posX = ranPos.Next(1, 20);
                    en._posY = ranPos.Next(1, 40);
                    power._posX = ranPos.Next(1, 20);
                    power._posY = ranPos.Next(1, 40);
                }
            }
        }

        static void PowerCollision()
        {
            if (play._posX == power._posX && play._posY == power._posY)
            {
                play.destroy = true;
                power._active = false;
            }
        }
    }
}

