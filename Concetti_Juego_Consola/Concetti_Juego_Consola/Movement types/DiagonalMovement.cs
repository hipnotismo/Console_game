using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concetti_Juego_Consola
{ 
    class DiagonalMovement : EnemyMovement
    {
        public override void move(int type, int ran, ref int _posX, ref int _posY)
        {
            switch (ran)
            {
                case 1:
                    if (_posX > 1)
                    {
                        _posX--;
                        _posY--;
                    }
                    else
                    {
                        _posX++;
                        _posY++;
                    }
                    break;
                case 2:
                    _posX++;
                    _posY--;
                    break;
                case 3:
                    if (_posY > 1)
                    {
                        _posY--;
                        _posX++;

                    }
                    else
                    {
                        _posY++;
                        _posX--;

                    }
                    break;
                case 4:
                    _posY++;
                    _posX--;
                    break;
                default:
                    break;
            }
        }
    }
}
