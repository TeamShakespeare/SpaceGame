using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceGame
{
    public class EnemyShip : Ship
    {
        public EnemyShip(int healthPoint, int attackDamage):
            base(healthPoint , attackDamage)
        {

        }
    }
}
