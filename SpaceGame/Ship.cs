using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    [Serializable]
    public abstract class Ship : IWorldObject
    {
        private int healthPoint;
        private int attackDamage;
        protected MatrixCoords position;
        public Inventory Inventory { get; set; }

        public Ship(int healthPoint, int attackDamage, MatrixCoords position)
        {
            this.AttackDamage = attackDamage;
            this.HealthPoint = healthPoint;
            this.position = position;
            this.Inventory = new Inventory();
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
                return 10;
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


        public void Move()
        {
            throw new NotImplementedException();
        }

        public MatrixCoords GetTopLeft()
        {
            return position;
        }

        public virtual char[,] GetImage()
        {
            return new char[,] { { } };
        }


        public MatrixCoords Position
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


        public virtual void Update()
        {
        }
    }
}
