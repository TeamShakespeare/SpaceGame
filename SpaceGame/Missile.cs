using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceGame
{
    public class Missile : Projectile
    {

        public Missile(MatrixCoords coords)
            : base(coords)
        {

        }

        public override char[,] GetImage()
        {
            return new char[,]
            {
            {'0' , '7' , '0' },
            {'7' , '7' , '7'},
            {'3' , '0' , '3' },
            };
        }

        public override void Update()
        {
            this.position += new MatrixCoords(-1, 0);
        }
    }
}
