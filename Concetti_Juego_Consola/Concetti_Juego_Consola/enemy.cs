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
        public string _sym;
        public int _type;
        public int _ran;

        public Enemy(int posX, int posY, string sym, int type)
        {
            _posX = posX;
            _posY = posY;
            _sym = sym;
            _type = type;
        }

        public void EnemyMovement(int ran)
        {
            switch (_type)
            {
                case 1:
                    switch (ran)
                    {
                        case 1:
                            if (_posX > 1)
                            {
                                _posX--;
                            }
                            else
                            {
                                _posX++;
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
                            else
                            {
                                _posY++;
                            }
                            break;
                        case 4:
                            _posY++;
                            break;
                        default:
                            break;                      
                    }
                    break;
                case 2:
                    switch (ran)
                    {
                        case 1:
                            if (_posX > 1)
                            {
                                _posX--;
                            }
                            else
                            {
                                _posX++;
                            }
                            break;
                        case 2:
                            _posX++;
                            break;                       
                        default:
                            break;
                    }
                    break;
                case 3:
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
                    break;
                default:
                    break;
            }
        }

       public void EnemyDraw()
        {
            Console.SetCursorPosition(_posX, _posY);

            switch (_type)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                default:
                    break;
            }

            Console.Write(_sym,Console.ForegroundColor);
            Console.ResetColor();
        }
    }
}
