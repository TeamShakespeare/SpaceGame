using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceGame
{
    public class Bomb : Projectile
    {
        public Bomb(MatrixCoords coords)
            : base(coords)
        {

        }
        public override char[,] GetImage()
        {
            //TODO: DRAW BOMB
            return base.GetImage();
        }
    }
}
