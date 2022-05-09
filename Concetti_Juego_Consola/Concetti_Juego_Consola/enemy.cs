using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concetti_Juego_Consola
{
    class enemy
    {
        public int posY = 10;
        public int posX = 10;
        public int random = 0;

       public void enemyMovement(int random,ref int posX,ref int posY)
        {
            switch (random)
            {
                case 1:
                    if (posX > 1)
                    {
                        posX--;
                    }
                    else
                    {
                        posX++;
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
                    else
                    {
                        posY++;
                    }
                    break;
                case 4:
                    posY++;
                    break;
                default:
                    break;
            }
        }
       public void enemyDraw()
        {
            Console.SetCursorPosition(posX, posY);
            Console.Write("x");
        }
    }
}
