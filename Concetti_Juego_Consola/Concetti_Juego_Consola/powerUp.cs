using System;

namespace Concetti_Juego_Consola
{
    class PowerUp
    {
        public int _posY;
        public int _posX;
        public bool _active;
        public string _sym;

        public PowerUp(int posX, int posY, bool active, string sym)
        {
            _posY = posY;
            _posX = posX;
            _active = active;
            _sym = sym;
        }

        public void PowerDraw()
        {
            if (_active)
            {
                Console.SetCursorPosition(_posX, _posY);
                Console.Write(_sym);
            }
         
        }
    }
}
