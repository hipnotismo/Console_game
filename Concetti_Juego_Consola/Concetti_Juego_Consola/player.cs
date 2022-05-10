using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concetti_Juego_Consola
{
    class Player
    {
        public int _posY;
        public int _posX;
        public bool destroy = false;
        private string _sym;

        public Player(int posY, int posX, string sym)
        {
            _posX = posX;
            _posY = posY;
            _sym = sym;
        }
        public void PlayerMovement(int num)
        {         
            switch (num)
            {
                case 1:
                    if (_posX != 0)
                    {
                        _posX--;
                    }
                    break;
                case 2:                  
                    _posX++;
                    break;
                case 3:
                    if (_posY > 1)
                    {
                        _posY--;
                    }
                        break;
                case 4:
                    _posY++;
                    break;
                default:
                    break;
            }
        }

        public void PlayerDraw()
        {
            Console.SetCursorPosition(_posX, _posY);
            Console.Write(_sym);
        }
    }
}