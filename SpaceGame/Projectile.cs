using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceGame
{
    public abstract class Projectile : IWorldObject
    {
        private MatrixCoords position;

        public int DMGMultipier
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

        public MatrixCoords Position
        {
            get
            {
                return this.position;
            }
            set
            {
                this.position = value;
            }
        }

        public void Move()
        {
            throw new NotImplementedException();
        }

        public MatrixCoords GetTopLeft()
        {
            return this.Position;
        }

        public virtual char[,] GetImage()
        {
            return new char[,] { { '|' } };
        }
    }
}
