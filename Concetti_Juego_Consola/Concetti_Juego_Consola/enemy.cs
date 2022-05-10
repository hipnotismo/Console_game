using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concetti_Juego_Consola
{
    class Enemy
    {
        public int _posY;
        public int _posX;
        public int _ran;

        public Enemy(int posX, int posY)
        {
            _posX = posX;
            _posY = posY;
        }
       public void EnemyMovement(int random,ref int posX,ref int posY)
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
       public void EnemyDraw()
        {
            Console.SetCursorPosition(_posX, _posY);
            Console.Write("x");
        }
    }
}
