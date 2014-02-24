using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceGame
{
    public abstract class Projectile : IWorldObject
    {
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
            throw new NotImplementedException();
        }

        public char[,] GetImage()
        {
            throw new NotImplementedException();
        }
    }
}
