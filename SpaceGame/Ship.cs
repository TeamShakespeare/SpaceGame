using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    public abstract class Ship : IWorldObject
    {
        private int healthPoint;
        private int attackDamage;
        private Position position;

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

        public int Speed
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void Fire()
        {
            throw new System.NotImplementedException();
        }


        public bool Alive
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public Position Position
        {
            get { return this.position; }
            set { this.position = value; }
        }

        public void Move()
        {
            throw new NotImplementedException();
        }

        public MatrixCoords GetTopLeft()
        {
            throw new NotImplementedException();
        }

        public char[,] GetImage()
        {
            throw new NotImplementedException();
        }
    }
}
