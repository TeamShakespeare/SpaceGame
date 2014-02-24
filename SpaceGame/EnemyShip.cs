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
            return new char[,]
            {
            {'5' , '0' , '5' },
            {'5' , '5' , '5'},
            {'0' , '5' , '0' },
            };
        }
    }
}
