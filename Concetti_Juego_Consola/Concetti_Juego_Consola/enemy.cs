using System;

namespace Concetti_Juego_Consola
{
    class Enemy
    {
        public int _posY;
        public int _posX;
        public string _sym;
        public int _type;
        public int _ran;
        public EnemyMovement _movement ;

        public Enemy(int posX, int posY, string sym, int type, EnemyMovement movement)
        {
            _posX = posX;
            _posY = posY;
            _sym = sym;
            _type = type;
            _movement = movement;
        }

        public void EnemyMovement(int ran)
        {
            _movement.move(_type,ran, ref _posX, ref _posY);
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
