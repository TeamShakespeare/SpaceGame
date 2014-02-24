using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceGame
{
    public class Bullet : Projectile
    {
        public Bullet(MatrixCoords coords)
            : base(coords)
        {

        }

        public override void Update()
        {
            this.Position -= new MatrixCoords(3, 0);
        }
    }
}
