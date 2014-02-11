using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    public abstract class Ship
    {
        private int healthPoint;
        private int attackDamage;

        public Ship(int healthPoint , int attackDamage)
        {
            this.AttackDamage = attackDamage;
            this.HealthPoint = healthPoint;
        }

        public int AttackDamage
        {
            get { return attackDamage; }
            set { attackDamage = value; }
        }
        

        public int HealthPoint
        {
            get { return healthPoint; }
            set { healthPoint = value; }
        }
        
    }
}
