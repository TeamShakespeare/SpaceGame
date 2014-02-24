using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceGame
{
    public class Planet : IWorldObject
    {
        public MatrixCoords GetTopLeft()
        {
            throw new NotImplementedException();
        }

        public char[,] GetImage()
        {
            throw new NotImplementedException();
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


        MatrixCoords IWorldObject.Position
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


        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
