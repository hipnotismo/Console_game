namespace Concetti_Juego_Consola
{
    //(int posX, int posY, string sym, int type)
   abstract class EnemyMovement/* : Enemy*/
    {
        public EnemyMovement() /*: base(0,0,"",0)*/

        {

        }
        public abstract void move(int type, int ran, ref int _posX, ref int _posY);
       
    
        //void normalMovement(int ran, int _posX, int _posY)
        //{
           
        //}
   
        //void LateralMovement(int ran, int _posX, int _posY)
        //{
        //    switch (ran)
        //    {
        //        case 1:
        //            if (_posX > 1)
        //            {
        //                _posX--;
        //            }
        //            else
        //            {
        //                _posX++;
        //            }
        //            break;
        //        case 2:
        //            _posX++;
        //            break;
        //        default:
        //            break;
        //    }
        //}
    
        //void DiagonalMovement(int ran, int _posX, int _posY)
        //{
        //    switch (ran)
        //    {
        //        case 1:
        //            if (_posX > 1)
        //            {
        //                _posX--;
        //                _posY--;
        //            }
        //            else
        //            {
        //                _posX++;
        //                _posY++;
        //            }
        //            break;
        //        case 2:
        //            _posX++;
        //            _posY--;
        //            break;
        //        case 3:
        //            if (_posY > 1)
        //            {
        //                _posY--;
        //                _posX++;

        //            }
        //            else
        //            {
        //                _posY++;
        //                _posX--;

        //            }
        //            break;
        //        case 4:
        //            _posY++;
        //            _posX--;
        //            break;
        //        default:
        //            break;
        //    }
        //}
    }
}
