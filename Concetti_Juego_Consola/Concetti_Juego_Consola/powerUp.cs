using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concetti_Juego_Consola
{
    class powerUp
    {
        public int posY = 29;
        public int posX = 118;

        public void powerDraw()
        {
            Console.SetCursorPosition(posX, posY);
            Console.Write("@");
        }
    }
}
