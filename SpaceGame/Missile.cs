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
            //TODO: DRAW MISSILE
            return base.GetImage();
        }
    }
}
