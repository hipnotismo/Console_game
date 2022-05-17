namespace Concetti_Juego_Consola
{
    class LateralMovement : EnemyMovement
    {
        public override void move(int type, int ran, ref int _posX, ref int _posY)
        {
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
        }
    }
}
