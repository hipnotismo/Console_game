using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concetti_Juego_Consola
{
    class PowerUp
    {
        public int posY = 28;
        public int posX = 65;
        public bool active = true;

        public void PowerDraw()
        {
            if (active)
            {
                Console.SetCursorPosition(posX, posY);
                Console.Write("@");
            }
         
        }
    }
}
