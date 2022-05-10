using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concetti_Juego_Consola
{
    class Player
    {
        public int posY = 2;
        public int posX = 2;
        public bool destroy = false;
        private int num;
        public Player(int posiY, int posiX)
        {
            posX = posiX;
            posY = posiY;
        }
        public void PlayerMovement(int num)
        {         
            switch (num)
            {
                case 1:
                    if (posX != 0)
                    {
                        posX--;
                    }
                    break;
                case 2:                  
                    posX++;
                    break;
                case 3:
                    if (posY > 1)
                    {
                        posY--;
                    }
                        break;
                case 4:
                    posY++;
                    break;
                default:
                    break;
            }
        }

        public void PlayerDraw()
        {
            Console.SetCursorPosition(posX, posY);
            Console.Write("☺");
        }
    }
}