using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceGame
{
    public class EnemyShip : Ship
    {
        public EnemyShip(int healthPoint, int attackDamage , MatrixCoords position):
            base(healthPoint , attackDamage , position)
        {

        }

        public override char[,] GetImage()
        {
            //TODO: DRAW ENEMY SHIP
            return base.GetImage();
        }
    }
}
