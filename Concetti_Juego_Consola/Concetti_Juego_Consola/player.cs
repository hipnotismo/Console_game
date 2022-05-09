using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concetti_Juego_Consola
{
    class player
    {
        public int posY = 2;
        public int posX = 2;

        public void playerMovement()
        {
            ConsoleKeyInfo cki = Console.ReadKey();
            if (cki.Key == ConsoleKey.LeftArrow)
            {
                if (posX != 0)
                {
                    posX--;
                }
            }

            if (cki.Key == ConsoleKey.RightArrow)
            {
                posX++;
            }

            if (cki.Key == ConsoleKey.UpArrow)
            {
                if (posY > 1)
                {
                    posY--;
                }
            }

            if (cki.Key == ConsoleKey.DownArrow)
            {
                posY++;
            }
        }
    }
}
